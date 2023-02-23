using Newtonsoft.Json;

namespace HttpDataLoader;

/// <summary>
/// Set a reader for calling and reading response into object.
/// </summary>
/// <typeparam name="T">Object type to be transformed into.</typeparam>
public abstract class HttpReaderBase<T>
{
    private readonly IUrlTemplateResolver templateResolver;

    /// <summary>
    /// Initializes a new instance of the <see cref="HttpReaderBase{T}"/> class.
    /// </summary>
    /// <param name="templateResolver">set url resolver.</param>
    protected HttpReaderBase(IUrlTemplateResolver templateResolver)
    {
        this.templateResolver = templateResolver;
    }

    private static HttpClient Client => new ();

    /// <summary>
    /// Read the request into object.
    /// </summary>
    /// <param name="templateName">Use the name of template.</param>
    /// <param name="parameters">use parameters for request.</param>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    public async Task<T?> Read(
        string templateName,
        IEnumerable<Parameter> parameters)
    {
        var template = this.templateResolver.Resolve(templateName);
        var url = template.Fill(parameters);
        var response = await Client.GetAsync(url);
        var contentString = await response.Content.ReadAsStringAsync();
        if (contentString != null)
        {
            return JsonConvert.DeserializeObject<T>(contentString);
        }

        return default;
    }
}

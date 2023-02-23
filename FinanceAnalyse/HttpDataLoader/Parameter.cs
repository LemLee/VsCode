namespace HttpDataLoader;

public class Parameter
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Parameter"/> class.
    /// </summary>
    /// <param name="name">Name of Parameter.</param>
    /// <param name="value">Value Of Parameter.</param>
    public Parameter(string name, string value)
    {
        Verifier.IsNotNull(name, nameof(name));
        Verifier.IsNotNull(value, nameof(value));

        this.Name = name;
        this.Value = value;
    }

    /// <summary>
    /// Gets or sets the name of Parameter.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the value of parameter.
    /// </summary>
    public string Value { get; set; }
}

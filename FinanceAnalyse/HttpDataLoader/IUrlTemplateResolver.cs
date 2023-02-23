namespace HttpDataLoader;

public interface IUrlTemplateResolver
{
    IUrlTemplate Resolve(string templateName);
}

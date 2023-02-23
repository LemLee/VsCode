namespace HttpDataLoader;

public interface IUrlTemplate
{
    Uri Fill(IEnumerable<Parameter> parameters);
}

namespace DesignPatterns.SpecificationPattern;

public interface IContext
{
    string ProductCode { get; }
    IDictionary<string, string> Parameters { get; }
}

public class Context : IContext
{
    public Context(string productCode, IDictionary<string, string> parameters)
    {
        ProductCode = productCode;
        Parameters = parameters;
    }

    public string ProductCode { get; }
    public IDictionary<string, string> Parameters { get; }
}
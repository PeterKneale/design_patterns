namespace DesignPatterns.SpecificationPattern;

public class ParameterValueSpecification : ISpecification<IContext>
{
    private readonly string _key;
    private readonly string _value;

    public ParameterValueSpecification(string key, string value)
    {
        _key = key;
        _value = value;
    }

    public bool IsSatisfied(IContext o)
    {
        return o.Parameters.ContainsKey(_key) && o.Parameters[_key] == _value;
    }
}
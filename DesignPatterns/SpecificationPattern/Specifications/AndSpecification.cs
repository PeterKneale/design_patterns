namespace DesignPatterns.SpecificationPattern;

public class AndSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _first;
    private readonly ISpecification<T> _second;

    public AndSpecification(ISpecification<T> first, ISpecification<T> second)
    {
        _first = first;
        _second = second;
    }

    public bool IsSatisfied(T o)
    {
        return _first.IsSatisfied(o) && _second.IsSatisfied(o);
    }
}
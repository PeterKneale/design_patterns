namespace DesignPatterns.SpecificationPattern;

public interface ISpecification<T>
{
    bool IsSatisfied(T o);
}
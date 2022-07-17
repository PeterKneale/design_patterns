namespace DesignPatterns.SpecificationPattern;

public class ProductSpecification : ISpecification<IContext>
{
    private readonly string _productCode;

    public ProductSpecification(string productCode)
    {
        _productCode = productCode;
    }

    public bool IsSatisfied(IContext o)
    {
        return _productCode == o.ProductCode;
    }
}
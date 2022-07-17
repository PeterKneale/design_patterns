using System;

namespace DesignPatterns.SpecificationPattern;

public class QuestionSpecification
{
    public QuestionSpecification(string code, ISpecification<IContext> specification, DateTime from, DateTime? to = null)
    {
        Code = code;
        Specification = specification;
        From = from;
        To = to;
    }

    public string Code { get; }
    public DateTime From { get; }
    public DateTime? To { get; }
    public ISpecification<IContext> Specification { get; }
}
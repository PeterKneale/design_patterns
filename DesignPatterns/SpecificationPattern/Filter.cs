using System;

namespace DesignPatterns.SpecificationPattern;

public interface IFilter<T>
{
    IEnumerable<T> Apply(IEnumerable<T> items, IContext context);
}

public class Filter : IFilter<QuestionSpecification>
{
    public IEnumerable<QuestionSpecification> Apply(IEnumerable<QuestionSpecification> items, IContext context)
    {
        var now = DateTime.Now;
        return items
            .Where(x => x.From < now && (x.To == null || x.To > now))
            .Where(item => item.Specification.IsSatisfied(context));
    }
}
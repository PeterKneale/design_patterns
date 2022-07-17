using System;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.SpecificationPattern;

public class UnitTests
{
    [Fact]
    public void Contextual_filter_returns_correct_questions()
    {
        // arrange
        var context = new Context("ABC", new Dictionary<string, string>
        {
            {"X", "1"},
            {"Y", "2"}
        });
        var questions = new QuestionSpecification[]
        {
            new("Q1", new ParameterValueSpecification("X", "1"), new DateTime(2000, 1, 1)), // ✔
            new("Q2", new ParameterValueSpecification("Y", "2"), new DateTime(2000, 1, 1)), // ✔
            new("Q3", new AndSpecification<IContext>(new ParameterValueSpecification("X", "1"), new ParameterValueSpecification("Y", "2")), new DateTime(2000, 1, 1)), // ✔
            new("Q4", new ProductSpecification("ABC"), new DateTime(2000, 1, 1)), // ✔
            new("Q5", new ProductSpecification("XYZ"), new DateTime(2000, 1, 1)), // ❌ (wrong product)
            new("Q6", new ParameterValueSpecification("B", "134"), new DateTime(2000, 1, 1)), // ❌ (wrong parameter)
            new("Q7", new ProductSpecification("ABC"), new DateTime(1985, 1, 1), new DateTime(1992, 1, 1)) // ❌ (effective dates)
        };

        // act
        var results = new Filter().Apply(questions, context);

        // assert
        results.Select(x => x.Code).Should().BeEquivalentTo("Q1", "Q2", "Q3", "Q4");
    }
}
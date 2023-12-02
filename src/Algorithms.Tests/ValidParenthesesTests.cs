using Algorithms.Core;

namespace Algorithms.Tests;

public class ValidParenthesesTests
{
    private readonly ValidParentheses _sut;

    public ValidParenthesesTests()
    {
        _sut = new ValidParentheses();
    }

    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    public void IsValidParenthesesTests(string value, bool expected)
    {
        var result = _sut.StackIsValidParentheses(value);
        
        Assert.Equal(expected, result);
    }
}
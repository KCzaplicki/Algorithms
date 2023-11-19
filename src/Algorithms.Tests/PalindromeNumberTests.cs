using Algorithms.Core;

namespace Algorithms.Tests;

public class PalindromeNumberTests
{
    private readonly PalindromeNumber _sut;

    public PalindromeNumberTests()
    {
        _sut = new PalindromeNumber();
    }
    
    [Theory]
    [InlineData(0, true)]
    [InlineData(1, true)]
    [InlineData(11, true)]
    [InlineData(121, true)]
    [InlineData(123, false)]
    [InlineData(1221, true)]
    [InlineData(1222, false)]
    [InlineData(12321, true)]
    [InlineData(12311, false)]
    [InlineData(123321, true)]
    [InlineData(1234321, true)]
    [InlineData(1410110141, true)]
    public void IsPalindromeTests(int value, bool expected)
    {
        var result = _sut.SideChecksIsPalindrome(value);
        
        Assert.Equal(expected, result);
    }
}
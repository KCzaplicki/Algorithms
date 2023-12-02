using Algorithms.Core;

namespace Algorithms.Tests;

public class TwoPointersTechniqueTests
{
    private readonly TwoPointersTechnique _sut;
    
    public TwoPointersTechniqueTests()
    {
        _sut = new TwoPointersTechnique();
    }
    
    [Theory]
    [InlineData(new int[0], 1, new int[0])]
    [InlineData(new[] { 1, 2, 3 }, 5, new[] { 2, 3 })]
    [InlineData(new[] { 1, 2, 3, 4, 5, 9, 11 }, 7, new[] { 2, 5 })]
    [InlineData(new[] { 1, 2, 3, 4, 5, 9, 11 }, 9, new[] { 4, 5 })]
    [InlineData(new[] { 1, 2, 3, 4, 5, 9, 11 }, 14, new[] { 3, 11 })]
    public void SearchSumTest(int[] arr, int target, int[] expected)
    {
        var result = _sut.SearchSum(arr, target);
        
        Assert.Equal(expected, result);
    }
}
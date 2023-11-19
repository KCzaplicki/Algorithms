using Algorithms.Core;

namespace Algorithms.Tests;

public class TwoSumTests
{
    private TwoSum _sut;
    
    public TwoSumTests()
    {
        _sut = new TwoSum();
    }

    [Theory]
    [InlineData(new int[0], 1, new int[0])]
    [InlineData(new[] { 1, 2, 3 }, 5, new[] { 1, 2 })]
    [InlineData(new[] { 1, 2, 3, 5, 8, 9, 11, 13 }, 7, new[] { 1, 3 })]
    [InlineData(new[] { 1, 2, 3, 4, 5, 8, 9, 11, 13 }, 8, new[] { 2, 4 })]
    [InlineData(new[] { 11, 3, 2, 5, 9 }, 8, new[] { 1, 3 })]
    [InlineData(new[] { 11, 3, 2, 5, 9 }, 12, new[] { 1, 4 })]
    public void TwoSumSearchTests(int[] arr, int target, int[] expected)
    {
        var result = _sut.HashMapSearch(arr, target);
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new int[0], 1, new int[0])]
    [InlineData(new[] { 1, 2, 3 }, 5, new[] { 2, 3 })]
    [InlineData(new[] { 1, 2, 3, 5, 8, 9, 11, 13 }, 7, new[] { 2, 5 })]
    [InlineData(new[] { 1, 2, 3, 4, 5, 8, 9, 11, 13 }, 8, new[] { 3, 5 })]
    [InlineData(new[] { 11, 3, 2, 5, 9 }, 8, new[] { 3, 5 })]
    [InlineData(new[] { 11, 3, 2, 5, 9 }, 12, new[] { 3, 9 })]
    public void TwoSumValuesSearchTests(int[] arr, int target, int[] expected)
    {
        var result = _sut.HashMapValuesSearch(arr, target);
        
        Assert.Equal(expected, result);
    }
}
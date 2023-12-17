using Algorithms.Core;

namespace Algorithms.Tests;

public class TopKFrequenciesTests
{
    private readonly TopKFrequencies _sut;
    
    public TopKFrequenciesTests()
    {
        _sut = new TopKFrequencies();
    }

    [Theory]
    [InlineData(new[] { 1 }, 1, new[] { 1 })]
    [InlineData(new[] { 1, 1, 1, 2, 2, 3 }, 2, new[] { 1, 2 })]
    [InlineData(new[] { 1, 1, 1, 2, 2, 2, 3, 3, 4 }, 2, new[] { 1, 2 })]
    [InlineData(new[] { 1, 1, 1, 1, 2, 2, 2, 3, 3, 4 }, 1, new[] { 1 })]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, 6, new[] { 1, 2, 3 ,4 ,5 ,6 })]
    public void TopKFrequenciesTest(int[] nums, int k, int[] expected)
    {
        var result = _sut.BucketSortTopKFrequencies(nums, k);

        Assert.Equal(expected, result);
    }
}
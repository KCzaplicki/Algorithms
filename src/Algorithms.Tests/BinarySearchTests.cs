using Algorithms.Core;

namespace Algorithms.Tests;

public class BinarySearchTests
{
    private readonly BinarySearch _sut;

    public BinarySearchTests()
    {
        _sut = new BinarySearch();
    }
    
    [Theory]
    [InlineData(new int[0], 1, null)]
    [InlineData(new[] { 1 }, 0, null)]
    [InlineData(new[] { 1 }, 1, 0)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 4, 3)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 1, 0)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 5, 4)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 3, 2)]
    [InlineData(new[] { 1, 3, 5, 7, 9, 11 }, 3, 1)]
    [InlineData(new[] { 1, 3, 5, 7, 9, 11 }, 9, 4)]
    public void BinarySearchTest(int[] arr, int value, int? expectedIndex)
    {
        var result = _sut.Search(arr, value);
        
        Assert.Equal(expectedIndex, result);
    }
}
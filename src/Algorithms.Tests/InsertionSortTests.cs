using Algorithms.Core;

namespace Algorithms.Tests;

public class InsertionSortTests
{
    private readonly InsertionSort _sut;
    
    public InsertionSortTests()
    {
        _sut = new InsertionSort();
    }
    
    [Theory]
    [InlineData(new int[0])]
    [InlineData(new[] { 1 })]
    [InlineData(new[] { 2, 2 })]
    [InlineData(new[] { 5, 2 })]
    [InlineData(new[] { 3, 1, 2, 5, 4 })]
    [InlineData(new[] { 9, 3, 5, 7, 2, 6, 8, 1, 4 })]
    public void SortTest(int[] array)
    {
        var expected = array.Order().ToArray();
        
        var result = _sut.Sort(array);
        
        Assert.True(expected.SequenceEqual(result));
    }
}
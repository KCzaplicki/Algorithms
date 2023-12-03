namespace Algorithms.Core;

// Given a array of integers, sort it in ascending order.
// Time complexity: O(n^2)
public class InsertionSort
{
    public int[] Sort(int[] array)
    {
        for (var i = 1; i < array.Length; i++)
        {
            var j = i;
            while (j > 0 && array[j - 1] > array[j])
            {
                (array[j - 1], array[j]) = (array[j], array[j - 1]);
                j--;
            }
        }
        
        return array;
    }
}
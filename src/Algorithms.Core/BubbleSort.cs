namespace Algorithms.Core;

// Given a array of integers, sort it in ascending order.
// Time complexity: O(n^2)
public class BubbleSort
{
    public int[] Sort(int[] array)
    {
        for (var i = 0; i < array.Length - 1; i++)
        {
            var swapped = false;
            for (var j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    swapped = true;
                }
            }
            
            if (!swapped)
            {
                break;
            }
        }
        
        return array;
    }
}
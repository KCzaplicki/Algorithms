namespace Algorithms.Core;

public class SelectionSort
{
    public int[] Sort(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            var minIndex = FindMinIndex(array, i);
            (array[i], array[minIndex]) = (array[minIndex], array[i]);
        }
        
        return array;
    }

    private int FindMinIndex(int[] array, int n)
    {
        int min = array[n], index = n;
        
        for (var i = n + 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                index = i;
                min = array[i];
            }
        }

        return index;
    }
}
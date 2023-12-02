namespace Algorithms.Core;

public class BinarySearch
{
    public int? Search(int[] arr, int value)
    {
        if (arr.Length == 0)
        {
            return null;
        }

        int start = 0, end = arr.Length - 1;

        while (start <= end)
        {
            var mid = start + end;
            var curr = arr[mid];

            if (curr == value)
            {
                return mid;
            }

            if (curr < value)
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }

        return null;
    }
}
namespace Algorithms.Core;

public class TwoPointersTechnique
{
    // Given a sorted array of integers, return a pair of numbers that sum to a given target.
    // If such a pair doesn't exist, return an empty array.
    // Time complexity: O(n)
    public int[] SearchSum(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            var sum = arr[left] + arr[right];
            if (sum == target)
            {
               return [arr[left], arr[right]];
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        
        return [];
    }
}
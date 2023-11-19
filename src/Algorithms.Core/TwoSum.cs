namespace Algorithms.Core;

// Given an array of integers, return a pair of numbers that are indexes to the values of sum to a given target.
// If such a pair doesn't exist, return an empty array.
// More on https://leetcode.com/problems/two-sum/
public class TwoSum
{
    // Time complexity: O(n^2)
    public int[] BruteForceSearch(int[] arr, int target)
    {
        for (var i = 0; i < arr.Length - 1; i++)
        {
            for (var j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == target)
                {
                    return [i, j];
                }
            }
        }
        
        return [];
    }
    
    // y = target - x
    // Time complexity: O(n)
    public int[] HashMapSearch(int[] arr, int target)
    {
        Dictionary<int, int> map = [];

        for (var i = 0; i < arr.Length; i++)
        {
            var y = target - arr[i];

            if (map.ContainsKey(y))
            {
                return [map[y], i];
            }

            map[arr[i]] = i;
        }
        
        return [];
    }
    
    // Version that returns the values instead of the indexes
    public int[] HashMapValuesSearch(int[] arr, int target)
    {
        Dictionary<int, bool> map = [];

        for (var i = 0; i < arr.Length; i++)
        {
            var y = target - arr[i];

            if (map.ContainsKey(y))
            {
                return [y, arr[i]];
            }

            map[arr[i]] = true;
        }
        
        return [];
    }
}
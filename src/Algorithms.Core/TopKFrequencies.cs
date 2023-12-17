namespace Algorithms.Core;

// Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.
// More on https://leetcode.com/problems/top-k-frequent-elements/
public class TopKFrequencies
{
    public int[] BucketSortTopKFrequencies(int[] nums, int k)
    {
        var frequencies = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!frequencies.ContainsKey(num))
            {
                frequencies[num] = 0;
            }
            
            frequencies[num]++;
        }

        var buckets = new List<int>[nums.Length + 1];

        foreach (var num in frequencies.Keys)
        {
            if (buckets[frequencies[num]] == null)
            {
                buckets[frequencies[num]] = new List<int>();
            }
            
            buckets[frequencies[num]].Add(num);
        }
        
        var result = new List<int>();

        for (var i = nums.Length; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i] != null)
            {
                result.AddRange(buckets[i]);   
            }
        }

        return result.ToArray();
    }
}
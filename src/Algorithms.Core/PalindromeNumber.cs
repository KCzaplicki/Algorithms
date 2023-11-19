namespace Algorithms.Core;

// Given an integer, return true if it's a palindrome.
// More on https://leetcode.com/problems/palindrome-number/
// Time complexity: O(n)
public class PalindromeNumber
{
    public bool BruteForceIsPalindrome(int value)
    {
        if (value < 0)
        {
            return false;
        }

        var valueStr = value.ToString();
        int left = 0, right = valueStr.Length - 1;

        while (left < right)
        {
            if (valueStr[left] != valueStr[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
    
    // Reverse(value) == value
    public bool ReversedNumberIsPalindrome(int value)
    {
        if (value < 0)
        {
            return false;
        }

        var reversed = 0;
        var original = value;

        while (value > 0)
        {
            reversed = reversed * 10 + value % 10;
            value /= 10;
        }

        return original == reversed;
    }
    
    public bool SideChecksIsPalindrome(int value)
    {
        long div = 1;
        while (value >= div * 10)
        {
            div *= 10;
        }

        while (value > 0)
        {
            long left = value / div;
            int right = value % 10;

            if (left != right)
            {
                return false;
            }

            value = (int)((value % div) / 10);
            div /= 100;
        }

        return true;
    }
}
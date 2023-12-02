namespace Algorithms.Core;

// Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
// More on https://leetcode.com/problems/valid-parentheses/
public class ValidParentheses
{
    public bool StackIsValidParentheses(string value)
    {
        var mappings = new Dictionary<char, char>
        {
            { '}', '{' },
            { ')', '(' },
            { ']', '[' }
        };

        var parentheses = new Stack<char>();

        foreach (var c in value)
        {
            if (!mappings.TryGetValue(c, out var closingBracket))
            {
                parentheses.Push(c);   
                continue;
            }

            if (parentheses.Count > 0 && closingBracket == parentheses.Peek())
            {
                parentheses.Pop();
            }
            else
            {
                return false;
            }
        }
        
        return parentheses.Count == 0;
    }
}
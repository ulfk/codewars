using System.Collections.Generic;
using System.Linq;

namespace Codewars;

public class ValidBraces
{
    // https://www.codewars.com/kata/5277c8a221e209d3f6000b56/csharp
    public static bool Validate(string input)
    {
        var dict = new Dictionary<char, char> { { ')', '(' }, { ']', '[' }, { '}', '{' } };
        var stack = new Stack<char>();
        foreach (var c in input)
        {
            if (dict.ContainsValue(c))
            {
                stack.Push(c);
            }
            else if (dict.ContainsKey(c) && stack.Any() && stack.Peek() == dict[c])
            {
                stack.Pop();
            }
            else
            {
                return false;
            }
        }

        return !stack.Any();
    }
}

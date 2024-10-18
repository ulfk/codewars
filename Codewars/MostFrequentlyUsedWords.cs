using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Codewars;

public class MostFrequentlyUsedWords
{
    public static List<string> Top3(string input)
    {
        var result = Regex.Matches(input, @"(\'*[A-Za-z]+(?:\'*[A-Za-z]+\'*)*\'?)")
            .Select(m => m.Value.ToLower())
            .GroupBy(m => m)
            .OrderByDescending(w => w.Count())
            .Select(w => w.Key)
            .Take(3)
            .ToList();
        return result;
    }
}
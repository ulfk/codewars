using System.Collections.Generic;
using System.Linq;

namespace Codewars;

/// <summary>
/// https://www.codewars.com/kata/58c5577d61aefcf3ff000081
/// </summary>
public class RailFenceCipher
{
    public static string Encode(string input, int numberOfRails)
    {
        if (numberOfRails == 1) return input;
        var rails = new string[numberOfRails];

        var railIdx = 0;
        var add = 1;
        for (var idx = 0; idx < input.Length; idx++)
        {
            rails[railIdx] += input[idx];
            if (railIdx + add < 0 || railIdx + add >= numberOfRails)
            {
                add *= -1;
            }
            railIdx += add;
        }

        return string.Join("", rails);
    }


    public static string Decode(string input, int numberOfRails)
    {
        if (numberOfRails == 1) return input;
        var rails = new List<int>[numberOfRails];
        for (var idx = 0; idx < rails.Length; idx++) rails[idx] = new List<int>();

        var railIdx = 0;
        var add = 1;
        for (var idx = 0; idx < input.Length; idx++)
        {
            rails[railIdx].Add(idx);
            if (railIdx + add < 0 || railIdx + add >= numberOfRails)
            {
                add *= -1;
            }
            railIdx += add;
        }

        var result = new char[input.Length];
        var inputIdx = 0;
        foreach (var chIdx in rails.SelectMany(rail => rail))
        {
            result[chIdx] = input[inputIdx++];
        }

        return new string(result);
    }
}

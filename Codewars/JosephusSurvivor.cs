using System.Linq;

namespace Codewars;

// https://www.codewars.com/kata/555624b601231dc7a400017a/csharp
public class JosephusSurvivor
{
    public static int JosSurvivor(int n, int k)
    {
        // cpu/ram intensive solution...
        
        var values = Enumerable.Range(1, n).ToArray();
        var idx = -1;
        while (values.Length > 1)
        {
            idx += k;
            while(idx >= values.Length) idx -= values.Length;
            values = values.Where(v => v != values[idx]).ToArray();
            idx--;
        }
        return values[0];
    }
}
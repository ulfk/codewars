using System.Linq;

namespace Codewars;

// https://www.codewars.com/kata/555624b601231dc7a400017a/csharp
public static class JosephusSurvivor
{
    public static int JosSurvivor(int n, int k)
    {
        // cpu/ram intensive solution...
        
        var values = Enumerable.Range(1, n).ToArray();
        var idx = 0;
        while (values.Length > 1)
        {
            idx = (idx + (k - 1)) % values.Length; 
            values = values.Where(v => v != values[idx]).ToArray();
        }
        return values[0];
    }
}
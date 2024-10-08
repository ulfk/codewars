namespace Codewars;

// https://www.codewars.com/kata/52f787eb172a8b4ae1000a34/csharp
public static class NumberOfTrailingZeros
{
    public static int TrailingZeros(int n)
    {
        var result = 0;
        var check = 5;
        while (n >= check)
        {
            result += n / check;
            check *= 5;
        }
        return result;
    }
}
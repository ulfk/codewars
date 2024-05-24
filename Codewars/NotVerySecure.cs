using System.Text.RegularExpressions;

namespace Codewars;

// https://www.codewars.com/kata/526dbd6c8c0eb53254000110/csharp
public static class NotVerySecure
{
    public static bool Alphanumeric(string str)
    {
        var regex = new Regex("[a-zA-Z0-9]+");
        return regex.IsMatch(str);
    }
}

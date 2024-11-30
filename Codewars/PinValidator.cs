using System.Text.RegularExpressions;

namespace Codewars
{
    // https://www.codewars.com/kata/55f8a9c06c018a0d6e000132

    public class PinValidator
    {
        public static bool ValidatePin(string pin)
        {
            return  Regex.IsMatch(pin, @"^(\d{4}|\d{6})\z");
        }
    }
}

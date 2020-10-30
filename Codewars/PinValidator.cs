using System;
using System.Text.RegularExpressions;

namespace Codewars
{
    public class PinValidator
    {
        public static bool ValidatePin(string pin)
        {
            return  Regex.IsMatch(pin, @"^(\d{4}|\d{6})\z");
        }
    }
}

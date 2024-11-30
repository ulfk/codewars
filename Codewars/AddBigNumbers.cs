using System;
using System.Collections.Generic;

namespace Codewars
{
    public class AddBigNumbers
    {
        // https://www.codewars.com/kata/525f4206b73515bffb000b21/train/csharp
        private const int NumDigits = 4;
        private static readonly long Divisor = (long)Math.Pow(10, NumDigits);
        private static readonly string Format = new string('0', NumDigits);

        public static string Add(string a, string b)
        {
            var aLength = a.Length;
            var bLength = b.Length;
            var maxLength = aLength > bLength ? aLength : bLength;
            var maxIdx = RoundUpToNumDigitsMultiple(maxLength);

            long carry = 0;
            var valueParts = new List<string>();
            for (var idx = NumDigits; idx <= maxIdx; idx += NumDigits)
            {
                var sum = SubstringValue(a, aLength - idx) + SubstringValue(b, bLength - idx);
                sum += carry;
                carry = sum / Divisor;
                var currentResult = sum % Divisor;
                AddToResults(valueParts, currentResult);
            }
            if(carry != 0)
                AddToResults(valueParts, carry);

            valueParts.Reverse();
            var result = string.Join("", valueParts).TrimStart('0');
            return result.Length > 0 ? result : "0";
        }

        private static void AddToResults(List<string> valueParts, long value) => valueParts.Add($"{value.ToString(Format)}");
        private static long RoundUpToNumDigitsMultiple(long value) => value % NumDigits != 0 ? (value / NumDigits + 1) * NumDigits : value;

        private static long SubstringValue(string val, int start)
        {
            if (start + NumDigits <= 0)
                return 0;
            var substr = start < 0 ? val.Substring(0, start + NumDigits) : val.Substring(start, NumDigits);
            return long.Parse(substr);
        }
    }
}

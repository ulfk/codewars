using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars
{
    public class MorseDecoder
    {
        private static class MorseCode
        {
            private static readonly Dictionary<string, String> MorseCodes = new()
            {
                {"A" , ".-"},
                {"B" , "-..."},
                {"C" , "-.-."},
                {"D" , "-.."},
                {"E" , "."},
                {"F" , "..-."},
                {"G" , "--."},
                {"H" , "...."},
                {"I" , ".."},
                {"J" , ".---"},
                {"K" , "-.-"},
                {"L" , ".-.."},
                {"M" , "--"},
                {"N" , "-."},
                {"O" , "---"},
                {"P" , ".--."},
                {"Q" , "--.-"},
                {"R" , ".-."},
                {"S" , "..."},
                {"T" , "-"},
                {"U" , "..-"},
                {"V" , "...-"},
                {"W" , ".--"},
                {"X" , "-..-"},
                {"Y" , "-.--"},
                {"Z" , "--.."},
                {"0" , "-----"},
                {"1" , ".----"},
                {"2" , "..---"},
                {"3" , "...--"},
                {"4" , "....-"},
                {"5" , "....."},
                {"6" , "-...."},
                {"7" , "--..."},
                {"8" , "---.."},
                {"9" , "----."},
            };

            public static string Get(string morseCode)
            {
                return MorseCodes.Single(k => k.Value == morseCode).Key;
            }
        }

        /*****************************************************************************/
        // https://www.codewars.com/kata/54b724efac3d5402db00065e/csharp
        public static string Decode(string morseCode)
        {
            var words = morseCode.Trim().Split(["   "], StringSplitOptions.None);
            var result = words.Select(word => word.Split(' ')).Select(letters => string.Join("", letters.Select(MorseCode.Get)));
            return string.Join(' ', result);
        }

        /*****************************************************************************/
        // https://www.codewars.com/kata/decode-the-morse-code-advanced

        private const string WordGlue = "   ";
        private const string CharGlue = " ";
        private static string _wordPause;
        private static string _charPause;
        private static string _signalPause;
        private static string _dot;
        private static string _dash;

        public static string DecodeMorse(string morseCode)
        {
            return Decode(morseCode.Trim(), WordGlue, DecodeMorseWord, " ");
        }

        public static string DecodeBits(string bits)
        {
            var trimmedBits = bits.Trim('0');
            var timeUnit = GetTransmissionRate(trimmedBits);
            InitConstants(timeUnit);
            return Decode(trimmedBits, _wordPause, DecodeSignalWord, WordGlue);
        }

        private static void InitConstants(int timeUnit)
        {
            _wordPause = new string('0', 7 * timeUnit);
            _charPause = new string('0', 3 * timeUnit);
            _signalPause = new string('0', timeUnit);
            _dot = new string('1', timeUnit);
            _dash = new string('1', 3 * timeUnit);
        }

        private static int GetTransmissionRate(string bits)
        {
            var minLength = int.MaxValue;
            var length = 0;
            var prevChar = '?';
            foreach (var bit in bits)
            {
                if (bit == prevChar)
                {
                    length++;
                    continue;
                }

                if (length > 0 && length < minLength)
                    minLength = length;

                prevChar = bit;
                length = 1;
            }

            if (length > 0 && length < minLength)
                minLength = length;

            return minLength;
        }

        private static string DecodeMorseWord(string word) => Decode(word, CharGlue, DecodeMorseChar);
        private static string DecodeMorseChar(string chr) => Decode(chr, CharGlue, DecodeMorseCode);
        private static string DecodeMorseCode(string code) => MorseCode.Get(code);

        private static string DecodeSignalWord(string word) => Decode(word, _charPause, DecodeSignalCode, CharGlue);
        private static string DecodeSignalCode(string code) => Decode(code, _signalPause, DecodeSignal);
        private static string DecodeSignal(string signal) => signal == _dot ? "." : (signal == _dash ? "-" : "?");

        private static string Decode(string text, string separator, Func<string,string> decoder, string glue = "") =>
            string.Join(glue, text.Split([separator], StringSplitOptions.None).Select(decoder));

    }


}

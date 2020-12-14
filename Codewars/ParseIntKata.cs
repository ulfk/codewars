
using System;
using System.Collections.Generic;

namespace Codewars
{
    public class ParseIntKata
    {
        // https://www.codewars.com/kata/525c7c5ab6aecef16e0001a5

        private class ResultValue
        {
            public ResultValue(Func<int, int> action, bool addToResult)
            {
                Execute = action;
                AddToResult = addToResult;
            }

            public Func<int, int> Execute { get; }

            public bool AddToResult { get; }
        }

        private static ResultValue Add(int value) => new ResultValue((a) => a + value, false);

        private static ResultValue Multiply(int value, bool addToResult) => new ResultValue((a) => a * value, addToResult);

        private static readonly Dictionary<string,ResultValue> LookupTable = new Dictionary<string, ResultValue>
        {
            {"zero",     Add(0) },
            {"and",      Add(0) },
            {"one",      Add(1) },
            {"two",      Add(2) },
            {"three",    Add(3) },
            {"four",     Add(4) },
            {"five",     Add(5) },
            {"six",      Add(6) },
            {"seven",    Add(7) },
            {"eight",    Add(8) },
            {"nine",     Add(9) },
            {"ten",      Add(10) },
            {"eleven",   Add(11) },
            {"twelve",   Add(12) },
            {"thirteen", Add(13) },
            {"fourteen", Add(14) },
            {"fifteen",  Add(15) },
            {"sixteen",  Add(16) },
            {"seventeen",Add(17) },
            {"eighteen", Add(18) },
            {"nineteen", Add(19) },
            {"twenty",   Add(20) },
            {"thirty",   Add(30) },
            {"forty",    Add(40) },
            {"fifty",    Add(50) },
            {"sixty",    Add(60) },
            {"seventy",  Add(70) },
            {"eighty",   Add(80) },
            {"ninety",   Add(90) },
            {"hundred",  Multiply(100, false) },
            {"thousand", Multiply(1000, true) },
            {"million",  Multiply(1000000, true) },
        };
        
        public static int ParseInt(string text)
        {
            var strings = text.Replace('-', ' ').ToLower().Split(' ');
            var pending = 0;
            var result = 0;
            foreach (var str in strings)
            {
                if(!LookupTable.TryGetValue(str, out var res))
                    throw new InvalidOperationException($"'{str}' not found");
                var val = res.Execute(pending);
                if (res.AddToResult)
                {
                    result += val;
                    pending = 0;
                }
                else
                {
                    pending = val;
                }
            }

            if (pending != 0)
                result += pending;

            return result;
        }
    }
}

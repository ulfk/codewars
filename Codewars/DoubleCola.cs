
namespace Codewars
{
    // https://www.codewars.com/kata/551dd1f424b7a4cdae0001f0/csharp

    public class DoubleCola
    {
        public static string WhoIsNext(string[] names, long nth)
        {
            var length = (long)names.Length;
            var total = length;
            var factor = 1L;
            while (nth > total)
            {
                factor *= 2;
                total += length * factor;
            }

            var offset = nth - (total - length * factor);
            return names[DivideAndCeiling(offset, factor) - 1];
        }

        private static long DivideAndCeiling(long dividend, long divisor)
        {
            var x = dividend / divisor;
            if (dividend % divisor > 0)
                x++;
            return x;
        }
    }
}

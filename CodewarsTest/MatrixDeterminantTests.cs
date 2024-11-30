using Codewars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTest
{
    [TestClass]
    public class MatrixDeterminantTests
    {
        private static readonly int[][][] Matrix =
        {
            [[1]],
            [[1, 3], [2, 5]],
            [[2, 5, 3], [1, -2, -1], [1, 3, 4]]
        };

        private static readonly int[] Expected = { 1, -1, -20 };

        private static readonly string[] Message = { "Determinant of a 1 x 1 matrix yields the value of the one element", "Should return 1 * 5 - 3 * 2 == -1 ", "" };


        [TestMethod]
        public void SampleTest()
        {
            for (int n = 0; n < Expected.Length; n++)
                Assert.AreEqual(Expected[n], MatrixDeterminant.Determinant(Matrix[n]), Message[n]);
        }
    }
}

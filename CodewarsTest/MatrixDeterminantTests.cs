using Codewars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTest
{
    [TestClass]
    public class MatrixDeterminantTests
    {
        private static int[][][] matrix =
        {
            new int[][] { new [] { 1 } },
            new int[][] { new [] { 1, 3 }, new [] { 2, 5 } },
            new int[][] { new [] { 2, 5, 3 }, new [] { 1, -2, -1 }, new [] { 1, 3, 4 } }
        };

        private static int[] expected = { 1, -1, -20 };

        private static string[] msg = { "Determinant of a 1 x 1 matrix yields the value of the one element", "Should return 1 * 5 - 3 * 2 == -1 ", "" };


        [TestMethod]
        public void SampleTest()
        {
            for (int n = 0; n < expected.Length; n++)
                Assert.AreEqual(expected[n], MatrixDeterminant.Determinant(matrix[n]), msg[n]);
        }
    }
}

using Codewars;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTest;

[TestClass]
public class TicTacToeCheckerTests
{
    [TestMethod]
    public void BasicTest()
    {
        int[,] board = { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
        var result = new TicTacToeChecker().IsSolved(board);
        result.Should().Be(1);
    }
}
using Codewars;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTest;

[TestClass]
public class GreedIsGoodTests
{
    [TestMethod]
    public void Tests()
    {
        //GreedIsGood.Score(new int[] { 2, 3, 4, 6, 2 }).Should().Be(0);
        //GreedIsGood.Score(new int[] { 4, 4, 4, 3, 3 }).Should().Be(400);
        //GreedIsGood.Score(new int[] { 2, 4, 4, 5, 4 }).Should().Be(450);
        GreedIsGood.Score([1, 1, 2, 3, 6]).Should().Be(200);
        GreedIsGood.Score([5, 5, 2, 3, 6]).Should().Be(100);
    }
}

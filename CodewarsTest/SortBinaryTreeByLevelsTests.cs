using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static Codewars.SortBinaryTreeByLevels;
using FluentAssertions;
using Codewars;

namespace CodewarsTest;

[TestClass]
public class SortBinaryTreeByLevelsTests
{
    [TestMethod]
    public void Test1()
    {
        var input = new Node(new Node(null, new Node(null, null, 4), 2), new Node(new Node(null, null, 5), new Node(null, null, 6), 3), 1);
        var expected = new List<int>() { 1, 2, 3, 4, 5, 6 };
        SortBinaryTreeByLevels.TreeByLevels(input).Should().BeEquivalentTo(expected);
    }
}

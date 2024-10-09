using System;
using Codewars;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTest;

[TestClass]
public class JosephusSurvivorTests
{
    [TestMethod]
    public void DummyTest()
    {
        // this is only a helper-test to try to find a pattern for an easier solution
        for (var n = 1; n < 30; n++)
        {
            Console.Write($"{n:00} : ");
            for (var k = 1; k < 20; k++)
            {
                var result = JosephusSurvivor.JosSurvivor(n, k);
                Console.Write($"{result:00} ");
            }
            Console.WriteLine("");
        }
    }

    [DataTestMethod]
    [DataRow(7, 3, 4)]
    [DataRow(11, 19, 10)]
    [DataRow(40, 3, 28)]
    [DataRow(14, 2, 13)]
    [DataRow(100, 1, 100)]
    [DataRow(1, 300, 1)]
    [DataRow(2, 300, 1)]
    [DataRow(5, 300, 1)]
    [DataRow(7, 300, 7)]
    [DataRow(300, 300, 265)]
    public void JosephusSurvivorTest(int n, int k, int expected)
    {
        JosephusSurvivor.JosSurvivor(n, k).Should().Be(expected);
    }
}
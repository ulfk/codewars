using Codewars;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTest
{
    [TestClass]
    public class ScreenLockPatternsTests
    {
        [TestMethod]
        public void TestC2()
        {
            ScreenLockPatterns.CountPatternsFrom('C', 2).Should().Be(5);
        }

        [TestMethod]
        public void TestA3()
        {
            ScreenLockPatterns.CountPatternsFrom('A', 3).Should().Be(31);
        }

    }
}
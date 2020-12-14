using Codewars;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTest
{
    [TestClass]
    public class ParseIntKataTests
    {
        [DataTestMethod]
        [DataRow("four hundred fifty two", 452)]
        [DataRow("two hundred forty-six", 246)]
        [DataRow("four hundred fifty two thousand", 452000)]
        [DataRow("five million four hundred fifty two thousand three hundred fifteen", 5452315)]
        public void ParseIntTests(string text, int result)
        {
            ParseIntKata.ParseInt(text).Should().Be(result);
        }
    }
}
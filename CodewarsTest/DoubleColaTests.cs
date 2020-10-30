using Codewars;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTest
{
    [TestClass]
    public class DoubleColaTests
    {

        [DataTestMethod]
        [DataRow(1, "Sheldon")]
        [DataRow(5, "Howard")]
        [DataRow(6, "Sheldon")]
        [DataRow(7, "Sheldon")]
        [DataRow(8, "Leonard")]
        [DataRow(52, "Penny")]
        [DataRow(7230702951, "Leonard")]
        public void DoubleColaTesting5(long nth, string result)
        {
            var names = new[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            DoubleCola.WhoIsNext(names, nth).Should().Be(result);
        }

        [DataTestMethod]
        [DataRow(1, "a")]
        [DataRow(2, "b")]
        [DataRow(3, "c")]
        [DataRow(4, "a")]
        [DataRow(5, "a")]
        [DataRow(6, "b")]
        [DataRow(7, "b")]
        [DataRow(8, "c")]
        [DataRow(9, "c")]
        [DataRow(10, "a")]
        public void DoubleColaTesting3(long nth, string result)
        {
            var names = new[] { "a", "b", "c" };
            DoubleCola.WhoIsNext(names, nth).Should().Be(result);
        }
    }
}
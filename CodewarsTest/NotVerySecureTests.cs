using Codewars;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTest;

[TestClass]
public class NotVerySecureTests
{
    [DataTestMethod]
    [DataRow("hello world", false)]
    [DataRow("   ", false)]
    [DataRow("HelloWordl123", true)]
    public void Test(string input, bool expectedResult)
    {
        NotVerySecure.Alphanumeric(input).Should().Be(expectedResult);
    }
}

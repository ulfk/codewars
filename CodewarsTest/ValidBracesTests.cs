using Codewars;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTest;

[TestClass]
public class ValidBracesTests
{
    [DataTestMethod]
    [DataRow("(){}[]",true)]
    [DataRow("([{}])",true)]
    [DataRow("(}",false)]
    [DataRow("[(])",false)]
    [DataRow("[({})](]",false)]
    public void ValidBracesTest(string input, bool result)
    {
        ValidBraces.Validate(input).Should().Be(result);
    }
}

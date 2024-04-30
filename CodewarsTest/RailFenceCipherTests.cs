using Codewars;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTest;

[TestClass]
public class RailFenceCipherTests
{
    [DataTestMethod]
    [DataRow("WEAREDISCOVEREDFLEEATONCE", 3, "WECRLTEERDSOEEFEAOCAIVDEN")]
    public void EncodeTest(string input, int rails, string expected)
    {
        RailFenceCipher.Encode(input, rails).Should().Be(expected);
    }

    [DataTestMethod]
    [DataRow("WECRLTEERDSOEEFEAOCAIVDEN", 3, "WEAREDISCOVEREDFLEEATONCE")]
    public void DecodeTest(string input, int rails, string expected)
    {
        RailFenceCipher.Decode(input, rails).Should().Be(expected);
    }
}

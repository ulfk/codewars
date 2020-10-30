using Codewars;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTest
{
    [TestClass]
    public class MorseDecoderTests
    {
        [TestMethod]
        public void MorseCodeTest()
        {
            MorseDecoder.DecodeMorse(".... . -.--   .--- ..- -.. .").Should().Be("HEY JUDE");
        }

        [TestMethod]
        public void MorseBitsTest()
        {
            MorseDecoder
                .DecodeBits(
                    "1100110011001100000011000000111111001100111111001111110000000000000011001111110011111100111111000000110011001111110000001111110011001100000011")
                .Should().Be(".... . -.--   .--- ..- -.. .");
        }
    }
}
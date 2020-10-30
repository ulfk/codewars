using Codewars;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTest
{
    [TestClass]
    public class PinValidatorTests
    {
        [TestMethod]
        public void TestPinValidator()
        {
            PinValidator.ValidatePin("1234\n").Should().BeFalse();
            PinValidator.ValidatePin("123456\n").Should().BeFalse();
            PinValidator.ValidatePin("1234").Should().BeTrue();
            PinValidator.ValidatePin("123456").Should().BeTrue();
            PinValidator.ValidatePin("1234567").Should().BeFalse();
            PinValidator.ValidatePin("123456a").Should().BeFalse();
            PinValidator.ValidatePin("123456x").Should().BeFalse();
        }
    }
}
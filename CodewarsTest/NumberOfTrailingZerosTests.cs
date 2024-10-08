using System;
using System.Numerics;
using Codewars;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTest;

[TestClass]
public class NumberOfTrailingZerosTests
{
    [TestMethod]
    public void BasicTests()
    {
        NumberOfTrailingZeros.TrailingZeros(4).Should().Be(0);
        NumberOfTrailingZeros.TrailingZeros(5).Should().Be(1);
        NumberOfTrailingZeros.TrailingZeros(9).Should().Be(1);
        NumberOfTrailingZeros.TrailingZeros(10).Should().Be(2);
        NumberOfTrailingZeros.TrailingZeros(14).Should().Be(2);
        NumberOfTrailingZeros.TrailingZeros(15).Should().Be(3);
        NumberOfTrailingZeros.TrailingZeros(24).Should().Be(4);
        NumberOfTrailingZeros.TrailingZeros(25).Should().Be(6);
        NumberOfTrailingZeros.TrailingZeros(25000).Should().Be(6249);
        NumberOfTrailingZeros.TrailingZeros(383171888).Should().Be(95792967);
    }
    
    [TestMethod]
    public void Demo()
    {
        for (BigInteger i = 1; i < 70; ++i)
        {
            var result = Factorial(i);
            var zeros = CountTrailingZeros(result);
            Console.WriteLine($"{i:00} : {zeros} - {result}");
        }
    }

    private static BigInteger Factorial(BigInteger val)
    {
        if (val < 1) throw new ArgumentException("value has to be 1 or greater");
        return (val == 1)? 1 : val * Factorial(val - 1);
    }
    
    private static int CountTrailingZeros(BigInteger value)
    {
        var count = 0;
        while (value % 10 == 0)
        {
            count++;
            value /= 10;
        }
        return count;
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codewars;
using FluentAssertions;
using System.Collections.Generic;

namespace CodewarsTest;

[TestClass]
public class ConnectFourTests
{
    [TestMethod]
    public void ConnectFourTest1()
    {
        List<string> myList =
        [
            "A_Red",
            "B_Yellow",
            "A_Red",
            "B_Yellow",
            "A_Red",
            "B_Yellow",
            "G_Red",
            "B_Yellow"
        ];
        ConnectFour.Play(myList).Should().Be("Yellow");
    }

    [TestMethod]
    public void ConnectFourTest2()
    {
        List<string> myList =
        [
            "C_Yellow",
            "E_Red",
            "G_Yellow",
            "B_Red",
            "D_Yellow",
            "B_Red",
            "B_Yellow",
            "G_Red",
            "C_Yellow",
            "C_Red",
            "D_Yellow",
            "F_Red",
            "E_Yellow",
            "A_Red",
            "A_Yellow",
            "G_Red",
            "A_Yellow",
            "F_Red",
            "F_Yellow",
            "D_Red",
            "B_Yellow",
            "E_Red",
            "D_Yellow",
            "A_Red",
            "G_Yellow",
            "D_Red",
            "D_Yellow",
            "C_Red"
        ];
        ConnectFour.Play(myList).Should().Be("Yellow");
    }

    [TestMethod]
    public void ConnectFourTest3()
    {
        List<string> myList =
        [
            "A_Yellow",
            "B_Red",
            "B_Yellow",
            "C_Red",
            "G_Yellow",
            "C_Red",
            "C_Yellow",
            "D_Red",
            "G_Yellow",
            "D_Red",
            "G_Yellow",
            "D_Red",
            "F_Yellow",
            "E_Red",
            "D_Yellow"
        ];
        ConnectFour.Play(myList).Should().Be("Red");
    }

    [TestMethod]
    public void ConnectFourTest4()
    {
        List<string> myList =
        [
            "F_Yellow",
            "G_Red",
            "D_Yellow",
            "C_Red",
            "A_Yellow",
            "A_Red",
            "E_Yellow",
            "D_Red",
            "D_Yellow",
            "F_Red",
            "B_Yellow",
            "E_Red",
            "C_Yellow",
            "D_Red",
            "F_Yellow",
            "D_Red",
            "D_Yellow",
            "F_Red",
            "G_Yellow",
            "C_Red",
            "F_Yellow",
            "E_Red",
            "A_Yellow",
            "A_Red",
            "C_Yellow",
            "B_Red",
            "E_Yellow"
        ];
        ConnectFour.Play(myList).Should().Be("Red");
    }


    [TestMethod]
    public void ConnectFourTest5()
    {
        List<string> myList =
        [
            "G_Yellow",
            "C_Red",
            "B_Yellow",
            "D_Red",
            "B_Yellow",
            "F_Red",
            "E_Yellow",
            "B_Red",
            "G_Yellow",
            "A_Red",
            "A_Yellow",
            "A_Red",
            "F_Yellow",
            "G_Red",
            "C_Yellow",
            "G_Red",
            "E_Yellow",
            "F_Red",
            "C_Yellow",
            "E_Red",
            "B_Yellow",
            "F_Red",
            "E_Yellow",
            "F_Red",
            "D_Yellow",
            "A_Red",
            "G_Yellow",
            "D_Red"
        ];
        ConnectFour.Play(myList).Should().Be("Yellow");
    }


    [TestMethod]
    public void ConnectFourTest6()
    {
        List<string> myList =
        [
            "F_Yellow",
            "E_Red",
            "A_Yellow",
            "B_Red",
            "D_Yellow",
            "D_Red",
            "G_Yellow",
            "B_Red",
            "B_Yellow",
            "F_Red",
            "E_Yellow",
            "C_Red",
            "E_Yellow",
            "G_Red",
            "A_Yellow",
            "B_Red",
            "A_Yellow",
            "A_Red",
            "B_Yellow",
            "B_Red",
            "D_Yellow",
            "E_Red",
            "E_Yellow",
            "G_Red",
            "E_Yellow",
            "F_Red",
            "D_Yellow",
            "A_Red",
            "C_Yellow",
            "C_Red",
            "D_Yellow",
            "F_Red",
            "G_Yellow",
            "G_Red",
            "D_Yellow"
        ];
        ConnectFour.Play(myList).Should().Be("Red");
    }

    [TestMethod]
    public void ConnectFourTest7()
    {
        List<string> myList =
        [
            "B_Yellow",
            "B_Red",
            "D_Yellow",
            "B_Red",
            "B_Yellow",
            "B_Red",
            "E_Yellow",
            "F_Red",
            "D_Yellow",
            "G_Red",
            "A_Yellow",
            "D_Red",
            "B_Yellow",
            "E_Red",
            "A_Yellow",
            "G_Red",
            "G_Yellow",
            "A_Red",
            "C_Yellow",
            "F_Red",
            "A_Yellow",
            "F_Red",
            "G_Yellow",
            "D_Red",
            "G_Yellow",
            "C_Red",
            "E_Yellow",
            "A_Red",
            "A_Yellow",
            "C_Red"
        ];
        ConnectFour.Play(myList).Should().Be("Yellow");
    }
}

﻿using Codewars;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodewarsTest
{
    [TestClass]
    public class AddBigNumbersTests
    {
        [DataTestMethod]
        [DataRow("12", "17", "29")]
        [DataRow("65", "45", "110")]
        [DataRow("5", "105", "110")]
        [DataRow("105", "5", "110")]
        [DataRow("2", "3", "5")]
        [DataRow("81231231", "1231231232", "1312462463")]
        [DataRow("0", "0", "0")]
        [DataRow("57853509440367665682450458794866464501746580388666517943654",
                 "1000000000000000000000000000000000000000000000000000000000000",
                 "1057853509440367665682450458794866464501746580388666517943654")]
        [DataRow("99999999999999999999999999999999999999999999999999",
                 "10000000000000000000000000000000000000000000000000001",
                 "10100000000000000000000000000000000000000000000000000")]
        [DataRow("30507080209030102040", "70602070408010506060", "101109150617040608100")]
        public void AddBigNumbersTest(string a, string b, string result)
        {
            AddBigNumbers.Add(a, b).Should().Be(result);
        }
    }
}
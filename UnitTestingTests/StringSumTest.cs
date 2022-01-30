using NUnit.Framework;
using System.Collections.Generic;
using UnitTesting;

namespace UnitTestingTests
{
    public class StringSumTest
    {
        [Test]
        public void Sum_WhenNumberIsEmptyString_Return0()
        {
            var number = "";
            var expectedResult = "0";

            var result = StringSum.Sum(number,number);

            Assert.AreEqual(result, expectedResult);
        }

        [TestCase("1","1","2")]
        [TestCase("2","5","7")]
        [TestCase("13", "87", "100")]
        public void Sum_WhenNumbersIsNatural_ReturnResultOfSum(string input1, string input2, string expectedResult)
        {
            var result = StringSum.Sum(input1, input2);

            Assert.AreEqual(result, expectedResult);
        }

        [TestCase("-1", "1", "1")]
        [TestCase("2.3", "5", "5")]
        public void Sum_WhenNumbersIsNotOnlyNatural_ReturnResultOfSum(string input1, string input2, string expectedResult)
        {
            var result = StringSum.Sum(input1, input2);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
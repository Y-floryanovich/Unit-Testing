using NUnit.Framework;
using System.Collections.Generic;
using UnitTesting;

namespace UnitTestingTests
{
    public class CalcStatsTest
    {
        [Test]
        public void GetStatistics_WhenMinValue1_Return1()
        {
            var input = new List<int> { 1, 2, 3, 4 };
            var expectedResult = "1";

            var result = CalcStats.GenerateCalcStats(input);

            Assert.AreEqual(result[0], expectedResult);
        }

        [Test]
        public void GetStatistics_WhenMaxValue111_Return111()
        {
            var input = new List<int> { 111, -2, 63, -411 };
            var expectedResult = "111";

            var result = CalcStats.GenerateCalcStats(input);

            Assert.AreEqual(result[1], expectedResult);
        }

        [Test]
        public void GetStatistics_WhenCountIs6_Return6()
        {
            var input = new List<int> { 1, 2, 3, 4, 4, 4 };
            var expectedResult = "6";

            var result = CalcStats.GenerateCalcStats(input);

            Assert.AreEqual(result[2], expectedResult);
        }


        [Test]
        public void GetStatistics_ShouldReturnAverage_ReturnRightAverage()
        {
            var input = new List<int> { 1, 3, 4, 4, 4 };
            var expectedResult = "3.2";

            var result = CalcStats.GenerateCalcStats(input);

            Assert.AreEqual(result[3], expectedResult);
        }

        [Test]
        public void GetStatistics_WhenListIsEmpty_ReturnNull()
        {
            var input = new List<int>();

            var result = CalcStats.GenerateCalcStats(input);

            Assert.IsNull(result);
        }
    }
}
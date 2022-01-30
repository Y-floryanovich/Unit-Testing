using NUnit.Framework;
using UnitTesting;

namespace UnitTestingTests
{
    public class OddEvenTest
    {
        [TestCase(100)]
        public void GenerateOddEven_CanPrintTo100_ReturnStringWithValue(int input)
        {
            var result = OddEven.GenerateOddEven(input);

            Assert.IsNotNull(result, string.Format("{0}", result));
        }

        [Test]
        public void GenerateOddEven_GivenNumberBelowOne_ReturnEmptyString()
        {
            var invalidIndex = -1;

            var result = OddEven.GenerateOddEven(invalidIndex);

            Assert.That(result, Is.Empty);
        }

        [TestCase(1, "Prime,")]
        [TestCase(3, "Prime,Prime,Prime,")]
        public void GenerateOddEven_GivenNumberUpTo3_ReturnStringsWithPrimeValues(int input, string expected)
        {
            var actual = OddEven.GenerateOddEven(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(4, "Prime,Prime,Prime,Even,")]
        [TestCase(6, "Prime,Prime,Prime,Even,Prime,Even,")]
        public void GenerateOddEven_GivenNumberUpTo6_ReturnStringsWithPrimeAndEvenValues(int input, string expected)
        {
            var actual = OddEven.GenerateOddEven(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(9, "Prime,Prime,Prime,Even,Prime,Even,Prime,Even,Odd,")]
        [TestCase(15, "Prime,Prime,Prime,Even,Prime,Even,Prime,Even,Odd,Even,Prime,Even,Prime,Even,Odd,")]
        public void GenerateOddEven_GivenNumberUpTo15_ReturnStringsWithPrimeAndEvenAndOddValues(int input, string expected)
        {
            var actual = OddEven.GenerateOddEven(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
using System;

namespace UnitTesting
{
    public class StringSum
    {
        public static string Sum(string num1, string num2)
        {
            var realNum1 = GetZeroWhenNullOrEmpty(num1);
            var realNum2 = GetZeroWhenNullOrEmpty(num2);
            var value1 = GetZeroWhenIsRealOrLessThenZero(realNum1);
            var value2 = GetZeroWhenIsRealOrLessThenZero(realNum2);
            return (value1+value2).ToString();
        }

        private static string GetZeroWhenNullOrEmpty(string num1) => string.IsNullOrEmpty(num1) ? "0" : num1;

        private static int GetZeroWhenIsRealOrLessThenZero(string num1)
        {
            var value = 0;
            var result = int.TryParse(num1, out value) && value > 0 ? value : 0;
            return result;
        }
    }
}

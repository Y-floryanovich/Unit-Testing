using System;

namespace UnitTesting
{
    public class OddEven
    {
        public static string GenerateOddEven(int max)
        {
            var result = string.Empty;
            if (max <= 0)
            {
                return result;
            }

            for (int i = 1; i < max + 1; i++)
            {
              result += GenerateSingleOddEven(i) + ",";
            }

            return result;
        }

        public static string GenerateSingleOddEven(int number)
        {
            if (number == 1 || number == 2 || IsPrime(number))
            {
                return "Prime";
            }

            if (IsEven(number))
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }

        private static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsEven(int number) => number >= 2 && number % 2 == 0;
    }
}

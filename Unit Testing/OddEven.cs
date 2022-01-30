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
                if(i == 1 || i == 2 || isPrime(i))
                {
                    result += "Prime,";
                    continue;
                }
                
                if (i % 2 == 0)
                {
                    result += "Even,";
                }
                else
                {
                    result += "Odd,";
                }
            }

            return result;
        }

        public static bool isPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

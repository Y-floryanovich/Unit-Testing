using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class CalcStats
    {
        public static List<string> GenerateCalcStats(List<int> numbers)
        {
            if(numbers == null || numbers.Count == 0)
            {
                return null;
            }

            var result = new List<string>(4);
            result.Add(numbers.Min().ToString());
            result.Add(numbers.Max().ToString());
            result.Add(numbers.Count().ToString());
            result.Add(numbers.Average().ToString());
            return result;
        }
    }
}

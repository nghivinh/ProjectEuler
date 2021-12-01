using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem16
    {
        public static int PowerDigitSum(int exponent)
        {
            BigInteger exponentOf2 = new BigInteger(Math.Pow(2, exponent));
            int sum = 0;

            foreach (var item in exponentOf2.ToString())
            {
                sum += int.Parse(item.ToString());
            }

            return sum;
        }
    }
}

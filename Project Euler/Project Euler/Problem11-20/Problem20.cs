using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem20
    {
        public static int SumFactorialDigits(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            int sum = 0;
            foreach (var item in factorial.ToString())
            {
                sum += int.Parse(item.ToString());
            }

            return sum;
        }
    }
}

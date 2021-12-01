using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem21
    {
        public static int SumAmicableNum(int n)
        {
            int sum = 0;
            for (int a = 1; a < n; a++)
            {
                int b = d(a);

                if (d(b) == a && b != a)
                {
                    sum += a;
                }
            }

            return sum;
        }

        static int d(int number)
        {
            int result = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    result += i;
            }
            return result;
        }
    }
}

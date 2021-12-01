using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem10
    {
        public static ulong PrimeSummation(int n)
        {
            ulong sum = 0;
            for (int i = 2;  ;i ++)
            {
                if (i >= n)
                    break;

                if (IsPrimeNumber(i))
                    sum += (ulong)i;
            }
            return sum;
        }

        static bool IsPrimeNumber(int num)
        {
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}

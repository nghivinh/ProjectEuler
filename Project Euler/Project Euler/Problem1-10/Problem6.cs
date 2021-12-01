using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem6
    {
        public static int SumSquareDifference(int n)
        {
            return SquareOfSum(n) - SumOfSquares(n);
        }

        static int SumOfSquares(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += (int)Math.Pow(i,2);
            }

            return sum;
        }

        static int SquareOfSum(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            return (int)Math.Pow(sum, 2);
        }
    }
}

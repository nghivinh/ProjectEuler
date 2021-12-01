using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem2
    {
        public static int FiboEvenSum(int n)
        {
            int a = 1;
            int b = 2;
            int sum = b;

            while(b <= n)
            {
                int temp = a;
                a = b;
                b = temp + a;

                if (b % 2 == 0)
                    sum += b;
            }

            return sum;
        }
    }
}

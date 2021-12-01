using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem3
    {
        public static int LargestPrimeFactor(long number)
        {
            int max = 0;
            int i = 2;

            while (number != 1)
            {
                if (IsPrimeNumber(i))
                {
                    if (number % i == 0)
                    {
                        max = i;
                        number = number / i;
                    }
                    else i++;
                }
                else i++;
            }

            return max;
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

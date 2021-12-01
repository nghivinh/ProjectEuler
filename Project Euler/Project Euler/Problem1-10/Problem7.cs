using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem7
    {
        public static int NthPrime(int n)
        {
			int count = 0;

            for (int i = 2;  ; i++)
            {
				if (IsPrimeNumber(i))
					count++;

				if (count == n)
					return i;
            }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem5
    {
        public static int SmallestMult(int n)
        {
            for (int i = 1; ; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i % j != 0)
                        break;
                    else
                    {
                        if (j == n)
                            return i;
                    }
                }
            }
        }
    }
}

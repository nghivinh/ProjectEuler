using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem9
    {
        public static void SpecialPythagoreanTriplet(int n)
        {
            for (int a = 1; a < n / 3; a++)
            {
                for (int b = a + 1; b < n / 2; b++)
                {
                    int c = n - a - b;

                    if (a * a + b * b == c * c)
                    {
                        Console.WriteLine("a={0} b={1} c={2}", a, b, c);
                        Console.WriteLine("a + b + c= " + n);
                        Console.WriteLine("a * b * c= " + a * b * c);
                    }
                }
            }
        }
    }
}

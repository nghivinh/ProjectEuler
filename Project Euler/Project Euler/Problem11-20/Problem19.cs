using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem19
    {
        public static int CountingSundays(int firstYear, int lastYear)
        {
            int count = 0;
            for (int i = firstYear; i <= lastYear; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    DateTime dateTime = new DateTime(i, j, 1);

                    if (dateTime.DayOfWeek == 0)
                        count++;
                }
            }

            return count;
        }
    }
}

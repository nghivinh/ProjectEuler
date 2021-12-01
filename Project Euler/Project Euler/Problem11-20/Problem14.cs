using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem14
    {
        public static int LongestCollatzSequence(int limit)
        {
            int startNumber = 2;
            int maxLength = 0;

            for (int i = 2; i < limit; i++)
            {
                int length = GenerateCollatzSequence(i);

                if (length > maxLength)
                {
                    maxLength = length;
                    startNumber = i;
                }
            }

            return startNumber;
        }
    

        static int GenerateCollatzSequence(int startNumber)
        {
            int length = 0;
            while (startNumber != 1)
            {
                startNumber = (startNumber % 2 == 0) ? (startNumber / 2) : (3 * startNumber + 1);
                length++;
            }

            return length;
        }
    }
}

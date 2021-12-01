using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem12
    {
        public static int DivisibleTriangleNumber(int n)//3
        {
            int currentNumber;

            for (int i = 1; ; i++)
            {
                currentNumber = (i * (i + 1)) / 2;

                //Tìm ước của số hiện tại
                int count = 0;
                for (int k = 1; k <= currentNumber; k++)
                {
                    if (currentNumber % k == 0)
                        count++;
                }

                if (count >= n)
                    return currentNumber;
            }
        }
    }

    /* Công thức nhanh tìm các số trong số tam giác
         x(x + 1)/2 với x là số tự nhiên: 1,2,3,4,...
    */
}

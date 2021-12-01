using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem4
    {
        public static ulong LargestPalindromeProduct(byte n)
        {
            int upperLimit = (int)Math.Pow(10,n) - 1;//giới hạn trên
            int lowerLimit = upperLimit/10 + 1;//giới hạn dưới

            ulong result = 0;

            for (int i = upperLimit; i > lowerLimit; i--)
            {
                for (int j = i; j > lowerLimit; j--)
                {
                    ulong temp = (ulong)(i * j);
                    if (IsSymmetryNumber(temp) && temp > result)
                        result = temp;
                }
            }

            return result;
        }

        public static bool IsSymmetryNumber(ulong number)
        {
            string text = number.ToString();

            string textLeft = text.Substring(0, text.Length / 2);
            string textRight = text.Substring(text.Length / 2);

            if (textLeft.Equals(Reverse(textRight)))
                return true;
            else
                return false;
        }

        static string Reverse(string text)
        {
            string result = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }
            return result;
        }
    }
}

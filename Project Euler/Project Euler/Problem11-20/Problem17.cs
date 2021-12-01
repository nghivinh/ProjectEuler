using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem17
    {
        public static int NumberLetterCounts(int limit)
        {
            int sum = 0;
            for (int i = 1; i <= limit; i++)
            {
                int temp = 
                sum += i.ToWords().Replace(" ","").Replace("-","").Length;
            }

            return sum;
        }
    }
}

/* Thư viện hỗ trợ chuyển số thành chữ
 * https://github.com/Humanizr/Humanizer
 * https://toidicodedao.com/2015/08/11/series-c-hay-ho-gioi-thieu-humanizer-mot-thu-vien-kha-thu-vi-cua-c/
 */



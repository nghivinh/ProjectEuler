using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem15
    {
        public static long LatticePaths(int gridSize)
        {
            //Vì đi trên viền của lưới nên tăng mảng lên 1 đơn vị;
            long[,] grid = new long[gridSize + 1, gridSize + 1];

            //Cho viền ngoài cùng bên phải và viền dưới cùng bằng 1
            for (int i = 0; i < gridSize; i++)
            {
                grid[i, gridSize] = 1; grid[gridSize, i] = 1;
            }

            //Đi từ góc phải dưới lên, 1 điểm = điểm liền kề phía dưới + điểm liền kế bên phải
            for (int i = gridSize - 1; i >= 0; i--)
            {
                for (int j = gridSize - 1; j >= 0; j--)
                {
                    grid[i, j] = grid[i + 1, j] + grid[i, j + 1];
                }
            }

            return grid[0, 0];
        }
    }
}
//Tham khảo: https://www.mathblog.dk/project-euler-15/

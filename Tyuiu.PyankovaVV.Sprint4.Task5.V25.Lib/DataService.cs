using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PyankovaVV.Sprint4.Task5.V25.Lib
{
    public class DataService : ISprint4Task5V25
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int collumn = matrix.Length / rows;
            int x = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < collumn; j++)
                {
                    if (matrix[i, j] > 0)
                        x += matrix[i, j];
                }
            }
            return x;
        }
    }
}

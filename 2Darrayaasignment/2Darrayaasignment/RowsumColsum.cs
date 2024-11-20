using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Darrayaasignment
{//6.WAP to find sum of each row and column of a matrix.
    internal class RowsumColsum
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            //row sum
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int rowsum = 0;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    rowsum += matrix[row, col];
                }
                Console.WriteLine($"SUM OF ROW IS:{rowsum}");
            }

            //colsum
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int colsum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    colsum += matrix[row, col];
                }
                Console.WriteLine($"SUM OF COL IS:{colsum}");
            }
        }
    }
}

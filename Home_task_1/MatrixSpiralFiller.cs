using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_task_1
{
    internal static class MatrixSpiralFiller
    {
        // TODO add tests
        public static void FillMatrixInSpirall(int[,] matrix, bool counterclockwise = true)
        {
            if (counterclockwise)
            {
                FillMatrixInSpiralCounterclockwise(matrix);
            }
            else
            {
                FillMatrixInSpiralClockwise(matrix);
            }
        }

        private static void FillMatrixInSpiralCounterclockwise(int[,] matrix)
        {
            int rows_count = matrix.GetLength(0);
            int cols_count = matrix.GetLength(1);

            if (rows_count == 1)
            {// роздрук тут лишній
                Console.WriteLine("It is impossible to fill such a matrix counterclockwise because it has only one row." +
                    "Try the clockwise method");
                return;
            }

            int operationsCount = rows_count * cols_count;
            // 0 => down, 1 => right, 2 => top, 3 => left
            int direction = 0;
            int row = 0, col = 0;
            int boundary = rows_count - 1;
// Покажете Ваш варіант на занятті для всіх
            for (int i = 1; i <= operationsCount; i++)
            {
                matrix[row, col] = i;

                switch (direction)
                {
                    case 0:
                        row++;
                        break;
                    case 1:
                        col++;
                        break;
                    case 2:
                        row--;
                        break;
                    case 3:
                        col--;
                        break;
                }

                if (i == boundary)
                {
                    direction = (direction + 1) % 4;
                    boundary += (direction % 2 == 0) ? --rows_count : --cols_count;
                }
            }
        }

        private static void FillMatrixInSpiralClockwise(int[,] matrix)
        {
            int rows_count = matrix.GetLength(0);
            int cols_count = matrix.GetLength(1);

            if (cols_count == 1)
            {
                Console.WriteLine("It is impossible to fill such a matrix counterclockwise because it has only one row." +
                    "Try the clockwise method");
                return;
            }
            int operationsCount = rows_count * cols_count;
            // 0 => right, 1 => bottom, 2 => left, 3 => top
            int direction = 0;
            int row = 0, col = 0;
            int boundary = cols_count - 1;

            for (int i = 1; i <= operationsCount; i++)
            {
                matrix[row, col] = i;

                switch (direction)
                {
                    case 0:
                        col++;
                        break;
                    case 1:
                        row++;
                        break;
                    case 2:
                        col--;
                        break;
                    case 3:
                        row--;
                        break;
                }

                if (i == boundary)
                {
                    direction = (direction + 1) % 4;
                    boundary += (direction % 2 == 0) ? --cols_count : --rows_count;
                }
            }
        }
    }
}

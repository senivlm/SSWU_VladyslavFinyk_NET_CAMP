using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home_task_1
{
    public static class TasksRepresenter
    {
        public static void Task1_SpiralMatrix()
        {
            Console.WriteLine("==============Task1==============");
            // TODO add user input
            int n = 3;
            int m = 4;

            int[,] matrix = new int[n, m];

            MatrixSpiralFiller.FillMatrixInSpirall(matrix, false);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void Task2_LongestColorFind()
        {
            Console.WriteLine("==============Task2==============");
            // TODO add user input
            var rnd = new Random();
            int[,] matrix = new int[7, 8];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(0, 16);
                    Console.Write("{0, 4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            var colorFinder = new ColorLineFinder(matrix);
            colorFinder.FindLongestColor();

            Console.WriteLine("Color info:");
            Console.WriteLine(colorFinder);
        }
    }
}
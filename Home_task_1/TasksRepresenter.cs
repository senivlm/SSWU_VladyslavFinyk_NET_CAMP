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
            int n = ReadIntNumber("rows", Validator.ValidateSequenceSizeInput);
            int m = ReadIntNumber("cols", Validator.ValidateSequenceSizeInput);
            int[,] matrix = new int[n, m];

            // TODO add user selection, maybe
            MatrixSpiralFiller.FillMatrixInSpirall(matrix);

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

            int n = ReadIntNumber("rows", Validator.ValidateSequenceSizeInput);
            int m = ReadIntNumber("cols", Validator.ValidateSequenceSizeInput);

            int[,] matrix = new int[n, m];
            var rnd = new Random();

            Console.WriteLine("Created matrix with random numbers");

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

        public delegate (string message, bool validationResult) ValidateSequenceSizeInput(int userInput);
        private static int ReadIntNumber(string sequenceName, params ValidateSequenceSizeInput[] SequenceInputValidators)
        {
            bool isNumberVerified = false;
            int sequenceSize = -1;
            string userInput;
            
            Console.WriteLine($"Input size of {sequenceName}");

            while (!isNumberVerified)
            {
                userInput = Console.ReadLine();

                if (userInput == null)
                {
                    Console.WriteLine("Input some value!");
                    continue;
                }
                try
                {
                    sequenceSize = Convert.ToInt32(userInput);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please, input a number!");
                    continue;
                }

                (string, bool) validationResult;
                bool isValidationsPassed = true;

                foreach (var validator in SequenceInputValidators)
                {
                    validationResult = validator(sequenceSize);
                    if (!validationResult.Item2)
                    {
                        Console.WriteLine(validationResult.Item1);
                        isValidationsPassed = false;
                        break;
                    }
                }
                isNumberVerified = isValidationsPassed ? true : false;
            }
            return sequenceSize;
        }
    }
}
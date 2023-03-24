using Home_task_1;

int n = 3;
int m = 4;

int[,] matrix = new int[n, m];

MatrixSpiralFiller.FillMatrixInSpirall(matrix, false);

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write("{0, 4}", matrix[i, j]);
    }
    Console.WriteLine();
}
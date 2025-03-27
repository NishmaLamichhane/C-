using System;

class AdditionOfMatrices
{
    static void Main()
    {
        int[,] matrix1 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int[,] matrix2 = {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
        };

        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        int[,] resultMatrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        Console.WriteLine("Resultant Matrix after Addition:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(resultMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
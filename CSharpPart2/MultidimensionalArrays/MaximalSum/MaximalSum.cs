using System;

/*
    Problem 2. Maximal sum

    Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
 * 
 * My Example:
 * 
 * matrix              |3x3 max sum     |max sum
 * 9 7 4 1             |9 7 4           |62
 * 6 8 9 1             |6 8 9           |
 * 1 9 9 1             |1 9 9           |
 * 1 2 3 1             |                |
 * 1 2 3 5             |                |
 *                     |                |
 * 3 6 9 1             |1 1 1     1 1 1 |46
 * 1 1 1 1             |6 9 9     5 6 9 |
 * 5 6 9 9             |9 5 5     9 9 5 |
 * 9 9 5 5
 * 
*/

class MaximalSum
{
    static void Main()
    {
        int[,] matrix =  ReadTwoDimensionalMatrix();
        int currentSum = 0;
        int maxSum = 0;
        int squareSize = 3;
        PrintTwoDimensionalMatrix(matrix);
        int rowMaxIndex = 0;
        int colMaxIndex = 0;

        for (int row = 0; row <= matrix.GetLength(0) - squareSize; row++)
        {
            for (int col = 0; col <= matrix.GetLength(1) - squareSize; col++)
            {
                 //currentSum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                 //       matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                 //       matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                for (int i = 0; i < squareSize; i++)
                {
                    for (int j = 0; j < squareSize; j++)
                    {
                        currentSum += matrix[row + i, col + j];
                    }
                }

                 if (currentSum > maxSum)
                 {
                     maxSum = currentSum;
                     rowMaxIndex = row;
                     colMaxIndex = col;
                 }
                 currentSum = 0;
            }
        }
        Console.WriteLine(maxSum);

        for (int row = rowMaxIndex, i = 0; i < squareSize; i++)
        {
            for (int col = colMaxIndex, j = 0; j < squareSize; j++)
            {
                Console.Write("{0, 2} ", matrix[row + i, col + j]);
            }
            Console.WriteLine();
        }
    }

    private static int[,] ReadTwoDimensionalMatrix()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Enter matrix[{0}, {1}]: ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        return matrix;
    }

    private static void PrintTwoDimensionalMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
namespace LoverOf2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    public class CalculatePath
    {
        private static int row, col;
        private static BigInteger sum = 0;

        public static void Main()
        {
            row = int.Parse(Console.ReadLine());
            col = int.Parse(Console.ReadLine());

            BigInteger[,] matrix = CreateMatrix(row, col);

            // PrintTheMatrix(matrix);
            int numberOfCodes = int.Parse(Console.ReadLine());
            double[] codes = Console.ReadLine()
                                            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(double.Parse)
                                            .ToArray();

            int coeff = Math.Max(row, col);
            int currRow = row - 1;
            int currCol = 0;
            sum = matrix[currRow, currCol];
            matrix[currRow, currCol] = 0;

            for (int i = 0; i < numberOfCodes; i++)
            {
                double code = codes[i];
                int rowToGo = (int)(code / (double)coeff);
                int colToGo = (int)(code % (double)coeff);
                currRow = MoveOnRows(matrix, rowToGo, currRow, currCol);
                currCol = MoveOnCols(matrix, colToGo, currRow, currCol);
            }

            Console.WriteLine(sum);
        }

        private static int MoveOnCols(BigInteger[,] matrix, int colToGo, int currRow, int currCol)
        {
            int newCol = currCol;

            while (currCol > colToGo)
            {
                newCol = currCol - 1;
                currCol--;

                if (currRow < row && newCol < col)
                {
                    sum += matrix[currRow, newCol];
                    matrix[currRow, newCol] = 0;
                }
            }

            while (currCol < colToGo)
            {
                newCol = currCol + 1;
                currCol++;
                if (currRow < row && newCol < col)
                {
                    sum += matrix[currRow, newCol];
                    matrix[currRow, newCol] = 0;
                }
            }
            
            return newCol;
        }

        private static int MoveOnRows(BigInteger[,] matrix, int rowToGo, int currRow, int currCol)
        {
            int newRow = currRow;

            while (currRow > rowToGo)
            {
                newRow = currRow - 1;
                currRow--;
                if (newRow < row && currCol < col)
                {
                    sum += matrix[newRow, currCol];
                    matrix[newRow, currCol] = 0;
                }
            }

            while (currRow < rowToGo)
            {
                newRow = currRow + 1;
                currRow++;
                if (newRow < row && currCol < col)
                {
                    sum += matrix[newRow, currCol];
                    matrix[newRow, currCol] = 0;
                }
            }

            return newRow;
        }

        private static void PrintTheMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0, 5} ", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static BigInteger[,] CreateMatrix(int rows, int columns)
        {
            BigInteger[,] matrix = new BigInteger[rows, columns];
            BigInteger value = 1;

            for (int col = 0; col < columns; col++)
            {
                for (int row = rows - 1; row >= 0; row--)
                {
                    bool isValueSet = false;

                    if (matrix[row, col] == 0)
                    {
                        matrix[row, col] = value;
                        isValueSet = true;
                    }

                    for (int step = 1; col + step < columns && row + step < rows; step++)
                    {
                        if (matrix[row + step, col + step] == 0)
                        {
                            matrix[row + step, col + step] = value;
                            isValueSet = true;
                        }
                    }

                    if (isValueSet)
                    {
                        value *= 2;
                    }
                }
            }

            return matrix;
        }
    }
}

using System;

/*
    Problem 1. Fill the matrix

    Write a program that fills and prints a matrix of size (n, n) as shown below:
    Example for n=4:

    a)	                b)	                c)	                d)*
    1	5	9	13      1	8	9	16      7	11	14	16      1	12	11	10
    2	6	10	14      2	7	10	15      4	8	12	15      2	13	16	9
    3	7	11	15      3	6	11	14      2	5	9	13      3	14	15	8
    4	8	12	16      4	5	12	13      1	3	6	10      4	5	6	7
*/
class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter size of matrix (n, n): ");
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];

        Console.WriteLine("Choose design of matrix: ");
        Console.Write("Enter: a, b, c or d: ");

        char choice = char.Parse(Console.ReadLine());
        switch (choice)
        {
            case 'a': MatrixA(matrix); break;
            case 'b': MatrixB(matrix); break;
            case 'c': MatrixC(matrix); break;
            case 'd': MatrixD(matrix); break;
        }
    }

    private static void PrintTheMatrix(int[,] matrix)
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

    private static void MatrixA(int[,] matrix)
    {
        /*
            a)	           
            1	5	9	13 
            2	6	10	14 
            3	7	11	15 
            4	8	12	16 
        */

        for (int col = 0, value = 1; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++, value++)
            {
                matrix[row, col] = value;
            }
        }

        PrintTheMatrix(matrix);
    }

    private static void MatrixB(int[,] matrix)
    {
        /*
            b)	           
            1	8	9	16 
            2	7	10	15 
            3	6	11	14 
            4	5	12	13 
        */
        for (int col = 0, value = 1; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++, value++)
                {
                    matrix[row, col] = value;
                }
            }
            else
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--, value++)
                {
                    matrix[row, col] = value;
                }
            }
        }
        PrintTheMatrix(matrix);
    }

    private static void MatrixC(int[,] matrix)
    {
        /*
            c)	size = 4;
         *      0    1   2   3
         *      --------------
              0| 7	11	14	16
              1| 4	8	12	15
              2| 2	5	9	13
              3| 1	3	6	10
        */
        for (int col = 0, value = 1; col < matrix.GetLength(1); col++)
        {
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                if (matrix[row, col] == 0)
                {
                    matrix[row, col] = value;
                    value++;
                }

                for (int goForward = 1; col + goForward < matrix.GetLength(1) && row + goForward < matrix.GetLength(0); goForward++)
                {

                    if (matrix[row + goForward, col + goForward] == 0)
                    {
                        matrix[row + goForward, col + goForward] = value;
                        value++;
                    }
                }
            }
        }
        PrintTheMatrix(matrix);
    }

    private static void MatrixD(int[,] matrix)
    {
        /*
            d)*
            1	12	11	10
            2	13	16	9
            3	14	15	8
            4	5	6	7
        */
        throw new NotImplementedException();
    }
}
using System;

/*
    Problem 3. Sequence n matrix

    We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
    Write a program that finds the longest sequence of equal strings in the matrix.
    Example:
 * ha mi si
 * ha li fi
 * ha ga ka
*/

class SequenceNMatrix
{
    static void Main()
    {
        //string[,] matrix = ReadTwoDimensionalMatrix();
        string[,] matrix =
        { 
            {"s", "qq", "s"},
            {"pp", "pp", "s"},
            {"pp", "qq", "s"}

            //{"ha", "fifi", "ho","hi"},
            //{"fo", "ha", "hi", "xx"},
            //{"xxx",	"ho", "ha", "xx"}

            //{ "ha", "ba", "ha" },
            //{ "li", "ha", "ga" },
            //{ "ha", "li", "sc"}
        };

        string elementCol = string.Empty;
        string elementRow = string.Empty;
        string elementDiag = string.Empty;
        string elementSecDiag = string.Empty;
        string mostFrequentElement = string.Empty;

        int currentNumberCol = 0;
        int currentNumberRow = 0;
        int currentNumberDiag = 0;
        int currentNumberSecDiag = 0;
        int maxNumber = 0;
        
        for (int col = 0, rowR = 0; col < matrix.GetLength(1); col++, rowR++)
        {
            for (int row = 0, colR = 0; row < matrix.GetLength(0); row++, colR++)
            {
                // Check columns
                if (row + 1 < matrix.GetLength(0))
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        currentNumberCol++;
                        elementCol = matrix[row, col];
                    }
                    else
                    {
                        currentNumberCol = 0;
                        elementCol = string.Empty;
                    }
                }
                // Check rows
                if (colR + 1 < matrix.GetLength(1) && rowR < matrix.GetLength(0))
                {
                    if (matrix[rowR, colR] == matrix[rowR, colR + 1])
                    {
                        currentNumberRow++;
                        elementRow = matrix[row, col];
                    }
                    else
                    {
                        currentNumberRow = 0;
                        elementRow = string.Empty;
                    }
                }
                // Check primary diagonals
                for (int goForward = 0; col + goForward + 1 < matrix.GetLength(1) && row + goForward + 1 < matrix.GetLength(0); goForward++)
                {
                    string firstDiag = matrix[row + goForward, col + goForward];
                    string secondDiag = matrix[row + goForward + 1, col + goForward + 1];
                    if (matrix[row + goForward, col + goForward] == matrix[row + goForward + 1,col + goForward + 1])
                    {
                        elementDiag = matrix[row + goForward, col + goForward];
                        currentNumberDiag++;
                    }
                    else
                    {
                        currentNumberDiag = 0;
                        elementDiag = string.Empty;
                    }
                }
                // Check secondary diagonals
                for (int goBackward = 0; row - goBackward - 1 >= 0 && col + goBackward + 1 < matrix.GetLength(1); goBackward++)
                {
                    string first = matrix[row - goBackward, col + goBackward];
                    string second = matrix[row - goBackward - 1, col + goBackward + 1];
                    if (matrix[row - goBackward, col + goBackward] == matrix[row - goBackward - 1,col + goBackward + 1])
                    {
                        elementSecDiag = matrix[row - goBackward, col + goBackward];
                        currentNumberSecDiag++;
                    }
                    else
                    {
                        currentNumberSecDiag = 0;
                        elementSecDiag = string.Empty;
                    }
                }
                // Find max
                if (currentNumberCol > currentNumberRow && currentNumberCol > currentNumberDiag && currentNumberCol > maxNumber)
                {
                    maxNumber = currentNumberCol;
                    mostFrequentElement = elementCol;

                    currentNumberCol = 0;
                    elementCol = string.Empty;
                }
                else if (currentNumberRow > currentNumberCol && currentNumberRow > currentNumberDiag && currentNumberRow > maxNumber)
                {
                    maxNumber = currentNumberRow;
                    mostFrequentElement = elementRow;

                    currentNumberRow = 0;
                    elementRow = string.Empty;
                }
                else if (currentNumberDiag > currentNumberCol && currentNumberDiag > currentNumberRow && currentNumberDiag > maxNumber)
                {
                    maxNumber = currentNumberDiag;
                    mostFrequentElement = elementDiag;

                    currentNumberDiag = 0;
                    elementDiag = string.Empty;
                }
                else if (currentNumberSecDiag > currentNumberRow && currentNumberSecDiag > currentNumberDiag && currentNumberSecDiag > currentNumberCol && currentNumberSecDiag > maxNumber)
                {
                    maxNumber = currentNumberSecDiag;
                    mostFrequentElement = elementSecDiag;

                    currentNumberSecDiag = 0;
                    elementSecDiag = string.Empty;
                }
            }
        }
        for (int i = 0; i <= maxNumber; i++)
        {
            Console.Write("{0}", mostFrequentElement);
            if (i != maxNumber)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }

    private static string[,] ReadTwoDimensionalMatrix()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rows, cols];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Enter matrix[{0}, {1}]: ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

        return matrix;
    }
}
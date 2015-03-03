namespace MaximalAreaSum
{
    using System;
    using System.IO;
    using System.Linq;

    /*
        Problem 5. Maximal area sum

        Write a program that reads a text file containing a square matrix of numbers.
        Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
        The first line in the input file contains the size of matrix N.
        Each of the next N lines contain N numbers separated by space.
        The output should be a single number in a separate text file.
     
        Example:

        input	    output
        4 
        2 3 3 4 
        0 2 3 4 
        3 7 1 2 
        4 3 3 2	    17
    */

    class MaximalAreaSum
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\Files\text.txt");
            
            int currentSum = 0;
            int maxSum = 0;
            int squareSize = 2;

            using (reader)
            {
                int size = int.Parse(reader.ReadLine());
                int[,] matrix = new int[size, size];

                // Read and save matrix
                string line = reader.ReadLine();
                for (int row = 0; line != null; row++)
                {
                    int[] numsInRow = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
                    for (int col = 0; col < numsInRow.Length; col++)
                    {
                        if (col < size)
                        {
                            matrix[row, col] = numsInRow[col];
                        }
                    }
                    line = reader.ReadLine();
                }
                // Get max sum
                for (int row = 0; row <= matrix.GetLength(0) - squareSize; row++)
                {
                    for (int col = 0; col <= matrix.GetLength(1) - squareSize; col++)
                    {
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
                        }
                        currentSum = 0;
                    }
                }
            }
            StreamWriter writer = new StreamWriter(@"..\..\Files\output.txt");
            using (writer)
            {
                writer.WriteLine(maxSum);
            }
        }
    }
}

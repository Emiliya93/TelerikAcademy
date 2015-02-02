namespace ZeroSubset
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int[,] subsets = new int[31, 5];
            for (int i = 0; i < 5; i++)
            {
                int current = numbers[i];
                for (int j = 0; j < subsets.GetLength(0); j++)
                {
                    if (subsets[j, 0] == 0)
                    {
                        subsets[j, 0] = current;
                        for (int row = 0; row < j; row++)
                        {
                            for (int col = 0; col < subsets.GetLength(1); col++)
                            {
                                if (subsets[row, col] == 0)
                                {
                                    subsets[row + j + 1, col] = current;

                                    break;
                                }

                                subsets[row + j + 1, col] = subsets[row, col];
                            }
                        }

                        break;
                    }
                }
            }

            for (int row = 0; row < subsets.GetLength(0); row++)
            {
                for (int col = 0; col < subsets.GetLength(1); col++)
                {
                    Console.Write(subsets[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

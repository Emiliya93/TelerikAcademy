using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggcelent
{
    class Eggcelent
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int height = 2 * n;
            int width = 3 * n + 1;

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (col >= (width - n + 1) / 2 && col < width - n - 1 && (row == 0 || row == height - 1))
                    {
                        Console.Write("*");
                    }
                    else if (2 * row + col == n + 1 || 2 * row + col == 6 * n - 3)// && row <= n / 2
                    {
                        Console.Write("*");
                    }
                    else if (2 * row - col == 3 * n - 3)
                    {
                        Console.Write("*");
                    }
                    else if (2 * row - col == -(2 * n - 1))
                    {
                        Console.Write("*");
                    }
                    else if ((row == n - 1 || row == n) && (col == 1 || col == width - 2))
                    {
                        Console.Write("*");
                    }
                    else if (row == n - 1 && (col > 1 && col < width - 2) && col % 2 == 0)// || row == n)
                    {
                        Console.Write("@");
                    }
                    else if (row == n && (col > 1 && col < width - 2) && col % 2 != 0)
                    {
                        Console.Write("@");
                    }
                    else if ((row >= n / 2 && row < height - n / 2) && (col == 1 || col == width - 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }


            /*
0123456789101112            
 .....***.....0
             
 ...*.....*...1
 .*.........*.2
             
 .*@.@.@.@.@*.3
              
 .*.@.@.@.@.*.4
 .*.........*.5
 ...*.....*...6
 .....***.....

             */
        }
    }
}

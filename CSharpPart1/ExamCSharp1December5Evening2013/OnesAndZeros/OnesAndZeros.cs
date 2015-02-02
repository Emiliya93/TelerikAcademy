using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesAndZeros
{
    class OnesAndZeros
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            char hash = '#';
            char dot = '.';
            /*
            A bit with value of 1 should be printed in the format:
            .#.
            ##.
            .#. 
            .#.
            ###

            A bit with value of 0 should be printed in the format:
            ###
            #.#
            #.#
            #.#
            ###
            */
            for (int row = 0; row < 5; row++)
            {
                for (int i = 15; i >= 0; i--)
                {
                    long mask = 1 << i;
                    long currentBit = (number & mask) >> i;

                    if (currentBit == 0)
                    {
                        switch (row)
                        {
                            case 0: Console.Write("{0}{0}{0}", hash); break;
                            case 1: 
                            case 2:
                            case 3: Console.Write("{0}{1}{0}", hash, dot); break;
                            case 4: Console.Write("{0}{0}{0}", hash); break;
                            default:
                                break;
                        }
                        if (i == 0)
                        {
                            continue;
                        }
                        Console.Write("{0}", dot);
                    }
                    else
                    {
                        switch (row)
                        {
                            case 0: Console.Write(".#."); break;
                            case 1: Console.Write("##."); break;
                            case 2: 
                            case 3: Console.Write(".#."); break;
                            case 4: Console.Write("###"); break;
                            default:
                                break;
                        }
                        if (i == 0)
                        {
                            continue;
                        }
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaBabaMiSmetalnika
{
    class NaBabaMiSmetalnika
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            uint[] numbers = new uint[8];
            // uint[] numbersBits = new uint[width];
            string[] numbersBits = new string[8];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = uint.Parse(Console.ReadLine());
                numbersBits[i] = Convert.ToString(numbers[i], 2).PadLeft(width, '0');
            }

            string instruction = Console.ReadLine();
            int line;
            int position;

            while (instruction != "stop")
            {
                switch (instruction)
                {
                    case "right":
                        {
                            line = int.Parse(Console.ReadLine());
                            position = int.Parse(Console.ReadLine());

                            // numbersBits[line][position];

                            uint currentBit = numbersBits[line][position];
                            int index = 0;
                            for (int i = position; i < width - 1; i++)
                            {
                                if (numbersBits[line][i] == 0)
                                {
                                    index = i;
                                }
                            }

                            uint mask = 1u << index - position;
                            uint nAndMask = numbers[line] & mask;
                            uint bit = nAndMask >> position;


                            //uint mask = 1u << position;
                            //uint nAndMask = numbers[line] & mask;
                            //uint bit = nAndMask >> position;
                            //Console.WriteLine("bit at position {0} -> {1}", position, bit);

                            //mask = 1u << position + 1;
                            //nAndMask = numbers[line] & mask;
                            //uint nextBit = nAndMask >> position + 1;
                            //Console.WriteLine("bit at position {0} -> {1}", position + 1, nextBit);
 
                            break;
                        }
                    case "left":
                        {
                            line = int.Parse(Console.ReadLine());
                            position = int.Parse(Console.ReadLine());

                            break;
                        }
                    case "reset":
                        {
                            break;
                        }
                    default: break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryFemaleGPS
{
    class AngryFemaleGPS
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long oddSum = 0;
            long evenSum = 0;
            long digit;

            if (number < 0)
            {
                number = Math.Abs(number);
            }

            while (number > 0)
            {
                digit = number % 10;
                number /= 10;
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
                else
                {
                    oddSum += digit;
                }
            }

            if (evenSum > oddSum)
            {
                Console.WriteLine("right {0}", evenSum);
            }
            else if (oddSum > evenSum)
            {
                Console.WriteLine("left {0}", oddSum);
            }
            else
            {
                Console.WriteLine("straight {0}", oddSum);
            }
        }
    }
}

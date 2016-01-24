using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Startup
    {
        static long[] memo;

        static long Fibonacci(long n)
        {
            if (memo[n] != 0)
            {
                return memo[n];
            }

            if (n == 1 || n == 2)
            {
                return 1;
            }

            long result = Fibonacci(n - 1) + Fibonacci(n - 2);
            result %= 1000000007;
            memo[n] = result;

            return result;
        }

        static void Main(string[] args)
        {
            long numN = long.Parse(Console.ReadLine());
            memo = new long[numN + 1];

            Console.WriteLine(Fibonacci(numN));

            // Without recursion
            //BigInteger a = 0;
            //BigInteger b = 1;

            //for (int i = 0; i < numN; i++)
            //{
            //    // Check if the number n is 1, and if the for loop is on the last number, than don't print the separator ", "
            //    if ((numN != 1))
            //    {
            //        a = a + b;
            //        b = a - b;
            //    }
            //}

            //Console.WriteLine(a % 1000000007);
        }
    }
}

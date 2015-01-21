using System;

/*
    Problem 16.** Bit Exchange (Advanced)

    Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
    The first and the second sequence of bits may not overlap.
*/
class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());

        Console.Write("Enter bit to exchange p: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Enter bit to exchange q: ");
        int q = int.Parse(Console.ReadLine());

        Console.Write("Enter k:");
        int k = int.Parse(Console.ReadLine());

        // Check if the sequences are more then 31 bits
        if (((p + (k - 1)) >= 32) || ((q + (k - 1)) >= 32))
        {
            Console.WriteLine("Out of range");
            System.Environment.Exit(0);
        }
        // Check if sequences overlap
        else if (((q >= p) && (q <= (p + (k - 1)))) || ((p >= q) && (p <= (q + (k - 1)))))
        {
            Console.WriteLine("Overlapping");
            System.Environment.Exit(0);
        }

        Console.WriteLine("Number binary representation: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));

        // Exchange bits
        for (int i = 0; i <= (k - 1); i++)
        {
            if (((number >> p) & 1) != ((number >> q) & 1))
            {
                number = number ^ (1u << p);
                number = number ^ (1u << q);
            }
            p++;
            q++;
        }

        Console.WriteLine("Binary result: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("Result: {0}", number);
    }
}

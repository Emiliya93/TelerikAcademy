using System;

class Program
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long result = 0;

        if (b == 3)
        {
            result = a + c;
        }
        else if (b == 6)
        {
            result = a * c;
        }
        else if (b == 9)
        {
            result = a % c;
        }

        long firstLineResult = result;
        if ((result % 3) == 0)
        {
            firstLineResult = result / 3;
        }
        else
        {
            firstLineResult = result % 3;
        }

        Console.WriteLine(firstLineResult);
        Console.WriteLine(result);
    }
}

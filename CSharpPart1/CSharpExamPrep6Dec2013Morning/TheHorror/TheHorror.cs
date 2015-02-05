using System;

class TheHorror
{
    static void Main()
    {
        string input = Console.ReadLine();
        int digitsCount = 0;
        long sum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (Char.IsDigit(input, i))
            {
                if ((i % 2) == 0)
                {
                    digitsCount++;
                    sum += (input[i] - '0');
                }
            }
        }

        Console.WriteLine("{0} {1}", digitsCount, sum);
    }
}
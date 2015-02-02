using System;

/*
    Problem 17.* Calculate GCD

    Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
    Use the Euclidean algorithm (find it in Internet).
    Examples:

    a	|b	    |GCD(a, b)
    3	|2	    |1
    60	|40	    |20
    5	|-15	|5
*/

class CalculateGCD
{
    static void Main()
    {
        Console.WriteLine("Enter two integers: ");
        Console.Write("1st: ");
        int dividend = int.Parse(Console.ReadLine());
        Console.Write("2nd: ");
        int divider = int.Parse(Console.ReadLine());

        // dividend should be > divider
        if (divider > dividend)
        {
            divider += dividend;
            dividend = divider - dividend;
            divider -= dividend;
        }

        int remainder;

        do
        {
            remainder = dividend % divider;
            dividend = divider;
            if (remainder != 0)
            {
                divider = remainder;
            }
        } while (remainder != 0);

        Console.WriteLine(divider);
    }
}

using System;

/*
    Problem 4. Multiplication Sign

    Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
    Use a sequence of if operators.

    Examples:
    a	|b	    |c	    |result
    5	|2	    |2	    |+
    -2	|-2	    |1	    |+
    -2	|4	    |3	    |-
    0	|-2.5	|4	    |0
    -1	|-0.5	|-5.1	|-
*/

class MultiplicationSign
{
    static void Main()
    {
        bool isMinus = false;
        bool isZero = false; 

        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Enter number {0}: ", i);
            double number = double.Parse(Console.ReadLine());

            if (number == 0)
            {
                isZero = true;
            }

            if (number < 0)
            {
                isMinus = !isMinus;
            }
        }

        if (isZero)
        {
            Console.WriteLine("0");
            return;
        }
        else
        {

            Console.WriteLine(isMinus ? "-" : "+");
        }
    }
}
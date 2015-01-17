using System;

/*
    Problem 5. Third Digit is 7?

    Write an expression that checks for given integer if its third digit from right-to-left is 7.
*/

class IsThirdDigitSeven
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        int thirdDigit = 0;

        for (int i = 0; i < 3; i++)
        {
            thirdDigit = number % 10;
            number = number / 10;
        }

        bool isThirdDigSeven = (thirdDigit == 7);

        Console.WriteLine("Is third digit 7 -> {0}", isThirdDigSeven);
    }
}
using System;

/*
    Problem 6. Four-Digit Number

    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
    Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
    Prints on the console the number in reversed order: dcba (in our example 1102).
    Puts the last digit in the first position: dabc (in our example 1201).
    Exchanges the second and the third digits: acbd (in our example 2101).
    The number has always exactly 4 digits and cannot start with 0.
*/
// TODO: try with arrays

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter four-digit number:");
        int number = int.Parse(Console.ReadLine());
        int firstDigit = 0;
        int secondDigit = 0;
        int thirdDigit = 0;
        int fourthDigit = 0;

        // Takes every digit of a four-digit number and saves it in separate variable
        for (int i = 1; i <= 4; i++, number /= 10)
        {
            if (i == 1)
            {
                fourthDigit = number % 10;
            }
            else if (i == 2)
            {
                thirdDigit = number % 10;
            }
            else if (i == 3)
            {
                secondDigit = number % 10;
            }
            else
            {
                firstDigit = number % 10;
            }
        }

        // Find and print the sum of the digits
        int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
        Console.WriteLine("Sum of digits: {0}", sum);

        // Print the number in reversed order
        Console.WriteLine("Reversed: {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);

        // Put the last digit in the first position
        Console.WriteLine("Last digit in front: {0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);

        // Exchanges the second and the third digits
        Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
    }
}

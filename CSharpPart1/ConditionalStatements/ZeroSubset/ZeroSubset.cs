using System;
using System.Text;

/*
Problem 12.* Zero Subset

We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
Assume that repeating the same subset several times is not a problem.
Examples:

numbers	        |result
3 -2 1 1 8	    |-2 + 1 + 1 = 0
3 1 -7 35 22	|no zero subset
1 3 -4 -2 -1	|1 + -1 = 0
                |1 + 3 + -4 = 0
                |3 + -2 + -1 = 0
1 1 1 -1 -1	    |1 + -1 = 0
                |1 + 1 + -1 + -1 = 0
0 0 0 0 0	    |0 + 0 + 0 + 0 + 0 = 0
*/

class ZeroSubset
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers: ");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int fourthNumber = int.Parse(Console.ReadLine());
        int fiftNumber = int.Parse(Console.ReadLine());

        /*
         * This method lies in that the binary representation of the numbers from 1 to 30 looks like that:
         * 00001
         * 00010
         * 00011
         * 00100
         * 00101
         * 00110
         * 00111
         * 01000
         * 01001
         * 01010
         * 01011
         * 01100
         * 01101
         * 01110
         * 01111
         * 10000
         * 10001
         * 10010
         * 10011
         * 10100
         * 10101
         * 10110
         * 10111
         * 11000
         * 11001
         * 11010
         * 11011
         * 11100
         * 11101
         * 11110
         * If every digit of that binary representation is one of the five integers, and when the digit is 1 the value of the corresponding int is added to sum variable,
         * this will run out every single subset combination. E.g. i = 10 (Binary: 01010) subset will be: secondInt + fourthInt.
         */

        int sum = 0;
        int counter = 0;
        StringBuilder zeroSubset = new StringBuilder();
        StringBuilder currentSubset = new StringBuilder();
        // string zeroSubset = string.Empty;
        // string finalSubset = string.Empty;

        for (int i = 1; i <= 30; i++)
        {
            sum = 0;
            // zeroSubset = string.Empty;
            currentSubset.Remove(0, currentSubset.Length);

            if ((i & 1) == 1)
            {
                sum += fiftNumber;
                // zeroSubset += fiftNumber.ToString() + " + ";
                currentSubset.Append(fiftNumber + " ");
            }
            if (((i >> 1) & 1) == 1)
            {
                sum += fourthNumber;
                // zeroSubset += fourthNumber.ToString() + " + ";
                currentSubset.Append(fourthNumber + " ");
            }
            if (((i >> 2) & 1) == 1)
            {
                sum += thirdNumber;
                // zeroSubset += thirdNumber.ToString() + " + ";
                currentSubset.Append(thirdNumber + " ");
            }
            if (((i >> 3) & 1) == 1)
            {
                sum += secondNumber;
                // zeroSubset += secondNumber.ToString() + " + ";
                currentSubset.Append(secondNumber + " ");
            }
            if (((i >> 4) & 1) == 1)
            {
                sum += firstNumber;
                // zeroSubset += firstNumber.ToString() + " + ";
                currentSubset.Append(firstNumber + " ");
            }

            if (sum == 0)
            {
                counter++;
                // finalSubset = zeroSubset + "\n";
                zeroSubset.Append(currentSubset);
                zeroSubset.AppendLine();
            }
        }

        if (counter == 0)
        {
            Console.WriteLine("no zero subsets");
        }
        else
        {
            //Console.Write(finalSubset);
            Console.WriteLine("Zero subsets:");
            Console.WriteLine(zeroSubset);
            Console.WriteLine();
        }
    }
}

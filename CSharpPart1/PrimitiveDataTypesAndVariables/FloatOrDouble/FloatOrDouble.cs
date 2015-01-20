using System;

/*
    Problem 2. Float or Double?

    Which of the following values can be assigned to a variable of type float and which to a variable of type double:
    34.567839023, 12.345, 8923.1234857, 3456.091?
    Write a program to assign the numbers in variables and print them to ensure no precision is lost.
*/

class FloatOrDouble
{
    static void Main()
    {
        double numberOne = 34.567839023;
        float numberTwo = 12.345F;
        double numberThree = 8923.1234857;
        float numberFour = 3456.091F;

        Console.WriteLine("{0} -> double{1}{2} -> float{1}{3} -> double{1}{4} -> float", numberOne, '\n', numberTwo, numberThree, numberFour);
    }
}

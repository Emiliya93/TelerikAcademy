using System;

/*
    Problem 6. Print Numbers

    Write a program to print the numbers 1, 101 and 1001, each at a separate line.
    Name the program correctly.
    You should submit in your homework the Visual Studio project holding the source code of the PrintNumbers program.
*/

class PrintNumbers
{
    static void Main()
    {
        Console.WriteLine(1);
        Console.WriteLine(101);
        Console.WriteLine(1001);

        // Using the binary number system (the numbers 1, 5 and 9 are the binary 1, 101 and 1001)
        Console.WriteLine("With loop \"for\":");
        for (int i = 1, number = 1; i <= 3; i++, number += 4)
        {
            Console.WriteLine(Convert.ToString(number, 2));
        }
    }
}

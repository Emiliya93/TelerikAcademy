using System;

/*
    Problem 9. Exchange Variable Values

    Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
    Print the variable values before and after the exchange.
*/
class ExchangeVariableValues
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Before exchange: a = {0}; b={1}", a, b);

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("After exchange: a = {0}; b = {1}", a, b);
    }
}
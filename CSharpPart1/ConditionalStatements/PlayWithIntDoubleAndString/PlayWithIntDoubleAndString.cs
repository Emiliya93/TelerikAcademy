using System;

/*
    Problem 9. Play with Int, Double and String

    Write a program that, depending on the user’s choice, inputs an int, double or string variable.
    If the variable is int or double, the program increases it by one.
    If the variable is a string, the program appends * at the end.
    Print the result at the console. Use switch statement.

    Example 1:
    program	                |user
    Please choose a type:	|
    1 --> int	            |
    2 --> double	        |3
    3 --> string	        |
    Please enter a string:	|hello
    hello*	

    Example 2:
    program	                |user
    Please choose a type:	|
    1 --> int	            |
    2 --> double	        |2
    3 --> string	        |
    Please enter a double:	|1.5
    2.5                     |
*/

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1 --> int; 2 --> double; 3 --> string");
        int typeChoice = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            // int
            case 1:
                {
                    Console.Write("Please enter a integer: ");
                    int intNumber = int.Parse(Console.ReadLine());
                    intNumber++;
                    Console.WriteLine(intNumber);
                    break;
                }
            // double
            case 2:
                {
                    Console.Write("Please enter a double: ");
                    double doubleNumber = double.Parse(Console.ReadLine());
                    doubleNumber++;
                    Console.WriteLine(doubleNumber);
                    break;
                }
            // string
            case 3:
                {
                    Console.Write("Please enter a string: ");
                    string inputString = Console.ReadLine();
                    inputString += "*";
                    Console.WriteLine(inputString);
                    break;
                }
            default:
                Console.WriteLine("Not a valid number! You have to choose between 1, 2 and 3.");
                break;
        }
    }
}
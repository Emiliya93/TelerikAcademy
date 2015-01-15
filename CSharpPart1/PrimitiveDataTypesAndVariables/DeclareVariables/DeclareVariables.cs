using System;

/*
    Problem 1. Declare Variables

    Declare five variables choosing for each of them the most appropriate of the types 
    byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
    52130, -115, 4825932, 97, -10000.
    Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
    Submit the source code of your Visual Studio project as part of your homework submission.
*/

class DeclareVariables
{
    static void Main()
    {
        ushort number1 = 52130;
        sbyte number2 = -115;
        int number3 = 4825932;
        byte number4 = 97;
        short number5 = -10000;

        Console.WriteLine("{0} -> ushort{1}{2} -> sbyte{1}{3} -> int{1}{4} -> byte{1}{5} -> short", 
            number1, '\n', number2, number3, number4, number5);
    }
}
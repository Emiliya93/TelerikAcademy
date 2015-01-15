using System;

/*
    Problem 12. Null Values Arithmetic

    Create a program that assigns null values to an integer and to a double variable.
    Try to print these variables at the console.
    Try to add some number or the null literal to these variables and print the result.
*/

class NullValuesArithmetic
{
    static void Main()
    {
        int? intNull = null;
        double? doubleNull = null;

        Console.WriteLine("Integer variable = null:{0};", intNull);
        Console.WriteLine("Double variable = null:{0};", doubleNull);

        intNull = intNull + 2;
        doubleNull = doubleNull + 5;

        Console.WriteLine("Int num + 2 ={0}; Double num + 5 ={1};", intNull, doubleNull);

        intNull = intNull + null;

        Console.WriteLine("Int num + null ={0};", intNull);
    }
}
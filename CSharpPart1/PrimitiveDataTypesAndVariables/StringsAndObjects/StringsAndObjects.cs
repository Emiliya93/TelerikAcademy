using System;

/*
    Problem 6. Strings and Objects

    Declare two string variables and assign them with Hello and World.
    Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
    Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
*/
class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";

        object helloWorld = hello + " " + world;

        string helloWorldConcatenated = (string)helloWorld;

        Console.WriteLine("First word: {0}{1}Second word: {2}{1}Object concatenation: {3}{1}String with the value of the object: {4}",
            hello, '\n', world, helloWorld, helloWorldConcatenated);
    }
}
/*
 *Refactor the following examples to produce code with well-named C# identifiers. 
 */
namespace PrintBoolOnConsole
{
    using System;

    class PrintInConsole
    {
        const int maxCount = 6;

        public static void Main()
        {
            Printer print = new Printer();
            print.PrintBool(true);
        }
    }
}
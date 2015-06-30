/*
 *Refactor the following examples to produce code with well-named C# identifiers. 
 */

namespace PrintBoolOnConsole
{
    using System;

    public class PrintInConsole
    {
        private const int MaxCount = 6;

        public static void Main()
        {
            Printer print = new Printer();
            print.PrintBool(true);
        }
    }
}
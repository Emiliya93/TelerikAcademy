namespace PrintBoolOnConsole
{
    using System;

    public class Printer
    {
        public void PrintBool(bool input)
        {
            string boolAsString = input.ToString();
            Console.WriteLine(boolAsString);
        }
    }
}

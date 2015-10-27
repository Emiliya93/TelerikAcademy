namespace Helpers.InputOutputUtils
{
    using System;

    public class ConsoleMessageProcessor : IMessageProcessor
    {
        public void PrintMessageOnLine(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadMessageOnLine()
        {
            return Console.ReadLine();
        }
    }
}

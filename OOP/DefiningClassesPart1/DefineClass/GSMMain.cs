namespace DefineClass
{
    using System;
    using System.Text;

    class GSMMain
    {
        static void Main()
        {
            string separator = new string('-', 40);
            int numberOfGsms = 3;

            // Test array
            Console.WriteLine(separator);
            Console.WriteLine("GSM TESTS:");
            Console.WriteLine();

            GSMTest testGsm = new GSMTest(numberOfGsms);
            testGsm.DisplayGSMs();
            Console.WriteLine("Static field:");
            Console.WriteLine();
            Console.WriteLine(testGsm.Iphone4s);

            // Add, delete and clear calls
            Console.WriteLine(separator);
            Console.WriteLine("CALL HISTORY TESTS:");
            Console.WriteLine();

            GSMCallHistoryTest testCallHistory = new GSMCallHistoryTest();
            testCallHistory.DisplayCalls();
            testCallHistory.DisplayPrice();
            Console.WriteLine(separator);
            Console.WriteLine("Deleting longest call...");
            Console.WriteLine();
            testCallHistory.DeleteLongest();
            testCallHistory.DisplayCalls();
            testCallHistory.DisplayPrice();

            Console.WriteLine(separator);
            Console.WriteLine("Clear all calls...");
            Console.WriteLine();
            testCallHistory.ClearCalls();
            testCallHistory.DisplayCalls();
            Console.WriteLine(separator);
        }
    }
}
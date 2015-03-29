namespace RangeExceptions
{
    using System;

    class RangeExTest
    {
        static void Main()
        {
            TestRangeExeptionWithInt();

            TestRangeExeptionWithDateTime();
        }

        private static void TestRangeExeptionWithDateTime()
        {
            //1.1.1980 … 31.12.2013].
            DateTime start = new DateTime(1980, 1, 1);
            DateTime end = new DateTime(2013, 12, 31);
            Console.WriteLine("Enter 3 dates in range [{0} - {1}]", start.Date, end.Date);

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    DateTime currentDate = ReadDate(start, end);
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static DateTime ReadDate(DateTime start, DateTime end)
        {
            Console.WriteLine("Enter date (yyyy.MM.dd):");
            DateTime currentDate = DateTime.Parse(Console.ReadLine());
            if (currentDate < start || currentDate > end)
            {
                throw new InvalidRangeException<DateTime>("Date not in range", start, end);
            }

            return currentDate;
        }

        private static void TestRangeExeptionWithInt()
        {
            int start = 1;
            int end = 100;
            Console.WriteLine("Enter 5 consecutive numbers in range [{0},{1}]: ", start, end);
            int[] numbers = new int[10];
            
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    numbers[i] = ReadNumber(start, end);
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private static int ReadNumber(int start, int end)
        {
            Console.WriteLine("Enter number in range [{0},{1}]", start, end);

            int number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new InvalidRangeException<int>("Number not in range", start, end);
            }
            return number;
        }
    }
}
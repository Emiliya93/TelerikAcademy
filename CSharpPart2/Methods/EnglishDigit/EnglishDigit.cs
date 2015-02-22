namespace EnglishDigit
{
    using System;

    /*
        Problem 3. English digit

        Write a method that returns the last digit of given integer as an English word.
        Examples:

        input	output
        512	two
        1024	four
        12309	nine
    */

    class EnglishDigit
    {
        static void Main()
        {
            string lastDigitAsWord = LastDigitAsWord();
            Console.WriteLine(lastDigitAsWord);
        }

        private static string LastDigitAsWord()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int digit = number % 10;
            string digitWord = string.Empty;
            switch (digit)
            {
                case 0: digitWord = "zero"; break;
                case 1: digitWord = "one"; break;
                case 2: digitWord = "two"; break;
                case 3: digitWord = "three"; break;
                case 4: digitWord = "four"; break;
                case 5: digitWord = "five"; break;
                case 6: digitWord = "six"; break;
                case 7: digitWord = "seven"; break;
                case 8: digitWord = "eight"; break;
                case 9: digitWord = "nine"; break;
            }
            return digitWord;
        }
    }
}
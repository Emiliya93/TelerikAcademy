using System;

/*
    Problem 11.* Number as Words

    Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
    Examples:

    numbers	|number as words
    0	    |Zero
    9	    |Nine
    10	    |Ten
    12	    |Twelve
    19	    |Nineteen
    25	    |Twenty five
    98	    |Ninety eight
    98	    |Ninety eight
    273	    |Two hundred and seventy three
    400	    |Four hundred
    501	    |Five hundred and one
    617	    |Six hundred and seventeen
    711	    |Seven hundred and eleven
    999	    |Nine hundred and ninety nine
*/

class NumberAsWords
{
    static void Main()
    {
        Console.Write("Enter a number in the range [0…999]: ");
        int userInput;

        while (!(int.TryParse(Console.ReadLine(), out userInput)))
        {
            Console.WriteLine("Input was not in correct format!");
            Console.Write("Enter a number in the range [0…999]: ");
        }

        int units = userInput % 10;
        userInput /= 10;

        int tenths = userInput % 10;
        userInput /= 10;

        int hundreds = userInput % 10;

        string unitsStr = string.Empty;
        string tenthsStr = string.Empty;
        string hundredsStr = string.Empty;
        string specialStr = string.Empty;

        if ((tenths == 1) && (units >=0 && units <=9))
        {
            switch (units)
            {
                case 0: tenthsStr = "ten"; break;
                case 1: tenthsStr = "eleven"; break;
                case 2: tenthsStr = "twelve"; break;
                case 3: tenthsStr = "thirteen"; break;
                case 4: tenthsStr = "fourteen"; break;
                case 5: tenthsStr = "fifteen"; break;
                case 6: tenthsStr = "sixteen"; break;
                case 7: tenthsStr = "seventeen"; break;
                case 8: tenthsStr = "eighteen"; break;
                case 9: tenthsStr = "nineteen"; break;
                default:
                    break;
            }
        }
        else
        {
            switch (units)
            {
                case 0: unitsStr = "zero"; break;
                case 1: unitsStr = "one"; break;
                case 2: unitsStr = "two"; break;
                case 3: unitsStr = "three"; break;
                case 4: unitsStr = "four"; break;
                case 5: unitsStr = "five"; break;
                case 6: unitsStr = "six"; break;
                case 7: unitsStr = "seven"; break;
                case 8: unitsStr = "eight"; break;
                case 9: unitsStr = "nine"; break;
                default:
                    break;
            }

            switch (tenths)
            {
                case 2: tenthsStr = "twenty"; break;
                case 3: tenthsStr = "thirty"; break;
                case 4: tenthsStr = "fourty"; break;
                case 5: tenthsStr = "fifty"; break;
                case 6: tenthsStr = "sixty"; break;
                case 7: tenthsStr = "seventy"; break;
                case 8: tenthsStr = "eighty"; break;
                case 9: tenthsStr = "ninety"; break;
                default:
                    break;
            }
        }

        switch (hundreds)
        {
            case 1: hundredsStr = "one hundred"; break;
            case 2: hundredsStr = "two hundred"; break;
            case 3: hundredsStr = "three hundred"; break;
            case 4: hundredsStr = "four hundred"; break;
            case 5: hundredsStr = "five hundred"; break;
            case 6: hundredsStr = "six hundred"; break;
            case 7: hundredsStr = "seven hundred"; break;
            case 8: hundredsStr = "eight hundred"; break;
            case 9: hundredsStr = "nine hundred"; break;
            default:
                break;
        }

        char upperLetter;

        #region printHundreds
        if (hundreds > 0 && tenths == 0 && units == 0)
        {
            upperLetter = (char)((int)hundredsStr[0] - 32);

            // Prints the word with upper first letter
            Console.Write(upperLetter);
            for (int i = 1; i < hundredsStr.Length; i++)
            {
                Console.Write(hundredsStr[i]);
            }
            Console.WriteLine();
        }
        #endregion
        #region printTenths
        else if (hundreds == 0 && tenths > 0 && units == 0)
        {
            upperLetter = (char)((int)tenthsStr[0] - 32);

            // Prints the word with upper first letter
            Console.Write(upperLetter);
            for (int i = 1; i < tenthsStr.Length; i++)
            {
                Console.Write(tenthsStr[i]);
            }
            Console.WriteLine();
        }
        #endregion
        #region printUnits
        else if (hundreds == 0 && tenths == 0 && units >= 0)
	    {
            upperLetter = (char)((int)unitsStr[0] - 32);

            // Prints the word with upper first letter
            Console.Write(upperLetter);
            for (int i = 1; i < unitsStr.Length; i++)
            {
                Console.Write(unitsStr[i]);
            }
            Console.WriteLine();
        }
        #endregion
        #region printAll
        else if (hundreds > 0 && tenths > 0 && units > 0)
        {
            upperLetter = (char)((int)hundredsStr[0] - 32);

            // Prints the word with upper first letter
            Console.Write(upperLetter);
            for (int i = 1; i < hundredsStr.Length; i++)
            {
                Console.Write(hundredsStr[i]);
            }
            Console.WriteLine(" and {0} {1}", tenthsStr, unitsStr);
        }
        #endregion
        #region printHundredsAndTenths
        else if (hundreds > 0 && tenths > 0 && units == 0)
        {
            upperLetter = (char)((int)hundredsStr[0] - 32);

            // Prints the word with upper first letter
            Console.Write(upperLetter);
            for (int i = 1; i < hundredsStr.Length; i++)
            {
                Console.Write(hundredsStr[i]);
            }
            Console.WriteLine(" and {0}", tenthsStr);
        }
        #endregion
        #region printHundredsAndUnits
        else if (hundreds > 0 && tenths == 0 && units > 0)
        {
            // Console.WriteLine("{0} and {1}", hundredsStr, unitsStr);

            upperLetter = (char)((int)hundredsStr[0] - 32);

            // Prints the word with upper first letter
            Console.Write(upperLetter);
            for (int i = 1; i < hundredsStr.Length; i++)
            {
                Console.Write(hundredsStr[i]);
            }
            Console.WriteLine(" and {0}", unitsStr);
        }
        #endregion
        #region printTenthsAndUnits
        else if (hundreds == 0 && tenths > 0 && units > 0)
        {
            // Console.WriteLine("{0} {1}", tenthsStr, unitsStr);

            upperLetter = (char)((int)tenthsStr[0] - 32);

            // Prints the word with upper first letter
            Console.Write(upperLetter);
            for (int i = 1; i < tenthsStr.Length; i++)
            {
                Console.Write(tenthsStr[i]);
            }
            Console.WriteLine(" {0}", unitsStr);
        }
        #endregion
    }
}

/* Telerik Academy Exam 1 @ 3 February 2015 Morning
    Original code (sent in BGCoder) for Task 5. Search in Bits:

    using System;

    class Program
    {
        static void Main()
        {
            int searched = byte.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int occurences = 0;
            int currentOccurr = 0;
            //int searchedBits = 4;
            //int numberBits = 30;
            int[] sBits = new int[4];
            int[] numBits = new int[30];

            // Find the most right 4 bits of S
                //int mask = 1 << 0;
                //int sAndMask = searched & mask;
                //int bit0 = sAndMask >> 0;

                //mask = 1 << 1;
                //sAndMask = searched & mask;
                //int bit1 = sAndMask >> 1;
            for (int p = 0; p < 4; p++)
            {
                int mask = 1 << p;
                int sAndMask = searched & mask;
                sBits[p] = sAndMask >> p;
            }

            for (int index = 0; index < n; index++)
            {
                int number = int.Parse(Console.ReadLine());
                // Find the 30 most right bits in the number 
                for (int p = 0; p < 30; p++)
                {
                    int mask = 1 << p;
                    int sAndMask = number & mask;
                    numBits[p] = sAndMask >> p;
                }
                // Search occurences
                bool hasOccurrence = true;

                for (int i = 0; i < 30; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if ((i + j) < 30)
                        {
                            if (sBits[j] == numBits[i + j])
                            {
                                hasOccurrence = true;
                            }
                            else
                            {
                                hasOccurrence = false;
                                break;
                            }
                        }
                        else
                        {
                            hasOccurrence = false;
                        }
                    }
                    if (hasOccurrence)
                    {
                        currentOccurr++;
                    }
                }

                // Count occurences
                occurences += currentOccurr;
                currentOccurr = 0;
            }
            Console.WriteLine(occurences);
        }
    }
*/

namespace SearchInBits
{
    using System;

    public class SearchEngine
    {
        public static void Main()
        {
            int searchedMostRightFourBits = byte.Parse(Console.ReadLine());
            int countOfGivenNumbers = int.Parse(Console.ReadLine());
            int occurrences = 0;
            int currentOccurr = 0;
            int[] searchedBits = new int[4];
            int[] currenrNumberBits = new int[30];

            for (int position = 0; position < 4; position++)
            {
                int mask = 1 << position;
                int searchedMostRightFourBitsAndMask = searchedMostRightFourBits & mask;
                searchedBits[position] = searchedMostRightFourBitsAndMask >> position;
            }

            for (int index = 0; index < countOfGivenNumbers; index++)
            {
                int number = int.Parse(Console.ReadLine());

                for (int position = 0; position < 30; position++)
                {
                    int mask = 1 << position;
                    int numberAndMask = number & mask;
                    currenrNumberBits[position] = numberAndMask >> position;
                }

                bool hasOccurrence = true;

                for (int i = 0; i < 30; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if ((i + j) < 30)
                        {
                            if (searchedBits[j] == currenrNumberBits[i + j])
                            {
                                hasOccurrence = true;
                            }
                            else
                            {
                                hasOccurrence = false;
                                break;
                            }
                        }
                        else
                        {
                            hasOccurrence = false;
                        }
                    }

                    if (hasOccurrence)
                    {
                        currentOccurr++;
                    }
                }

                occurrences += currentOccurr;
                currentOccurr = 0;
            }

            Console.WriteLine(occurrences);
        }
    }
}
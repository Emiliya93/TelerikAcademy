/* Refactor the following loop

    int i=0;
    for (i = 0; i < 100;) 
    {
       if (i % 10 == 0)
       {
        Console.WriteLine(array[i]);
        if ( array[i] == expectedValue ) 
        {
           i = 666;
        }
        i++;
       }
       else
       {
            Console.WriteLine(array[i]);
        i++;
       }
    }
    // More code here
    if (i == 666)
    {
        Console.WriteLine("Value Found");
    }
*/

namespace RefactorLoop
{
    using System;

    public class RefactoredLoop
    {
        public static void Main()
        {
            int[] array = new int[5];
            int i = 0;
            int expectedValue = 5;
            bool isValueFound = false;

            for (i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        // i = 666;
                        isValueFound = true;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }

            // More code here
            if (isValueFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}

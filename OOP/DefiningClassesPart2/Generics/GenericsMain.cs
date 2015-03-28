namespace Generics
{
    using System;
    using System.Collections.Generic;

    class GenericsMain
    {
        static void Main()
        {
            // Create list of 5 ints, assign 10 values and print them
            GenericList<int> list = new GenericList<int>(5);
            for (int i = 0; i < 10; i++)
            {
                list.AddElement((i + 10) * 6);
            }
            Console.WriteLine(list);
            Console.WriteLine();

            // Remove element by index
            int indexToRemove = 9;
            list.RemoveAt(indexToRemove);
            Console.WriteLine("Removed element at index {0}", indexToRemove);
            Console.WriteLine(list);
            Console.WriteLine();

            // Search element
            int numToSearch = 100;
            int indexOf = list.IndexOf(numToSearch);
            if (indexOf > 0)
            {
                Console.WriteLine("Index of {0} is: {1}", numToSearch, indexOf);
            }
            else
            {
                Console.WriteLine("The number {0} does not exist!", numToSearch);
            }
            Console.WriteLine();

            // Insert element
            int number = 152;
            int indexToInsert = 2;
            list.Insert(number, indexToInsert);
            Console.WriteLine("Inserted number {0} on index {1}", number, indexToInsert);
            Console.WriteLine(list);
            Console.WriteLine();

            // Find min and max
            Console.WriteLine("Min number is: {0}{1}Max number is: {2}", list.Min(), Environment.NewLine, list.Max());
        }
    }
}

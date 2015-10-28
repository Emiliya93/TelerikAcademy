namespace PrintSequenceMadeWithQueue
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        /// <summary>
        /// We are given the following sequence:
        /// S1 = N;
        /// S2 = S1 + 1;
        /// S3 = 2*S1 + 1;
        /// S4 = S1 + 2;
        /// S5 = S2 + 1;
        /// S6 = 2*S2 + 1;
        /// S7 = S2 + 2;
        /// ...
        /// Using the Queue&lt;T&gt; class write a program to print its first 50 members for given N.
        /// 
        /// Example: N=2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
        /// </summary>
        public static void Main()
        {
            const int NumberOfMembersToCalculate = 50;

            Console.WriteLine("Task 9");
            Console.WriteLine("Enter initial number for the sequence: ");

            // Counting on valid input :)
            int firstNumber = int.Parse(Console.ReadLine());

            // Sequence solution with a queue -> N, N+1, 2*N+1, N+2 
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(firstNumber);

            for (int i = 0; i < NumberOfMembersToCalculate; i++)
            {
                int current = queue.Dequeue();

                // Process the member
                Console.WriteLine(current);

                queue.Enqueue(current + 1);
                queue.Enqueue((2 * current) + 1);
                queue.Enqueue(current + 2);
            }
        }
    }
}

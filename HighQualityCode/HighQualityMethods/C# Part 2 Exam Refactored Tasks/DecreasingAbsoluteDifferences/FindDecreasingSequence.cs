namespace DecreasingAbsoluteDifferences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FindDecreasingSequence
    {
        public static void Main()
        {
            int seqCount = int.Parse(Console.ReadLine());

            bool[] isDecreasingSeq = new bool[seqCount];

            for (int i = 0; i < seqCount; i++)
            {
                int[] sequence = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                                   .Select(int.Parse)
                                                   .ToArray();

                int[] absDiffSeq = new int[sequence.Length - 1];
                for (int j = 0; j < sequence.Length - 1; j++)
                {
                    absDiffSeq[j] = AbsoluteDifference(sequence[j], sequence[j + 1]);
                }

                isDecreasingSeq[i] = IsDecreasingSequence(absDiffSeq);
            }

            Console.WriteLine(string.Join(Environment.NewLine, isDecreasingSeq));
        }

        private static bool IsDecreasingSequence(int[] absDiffSeq)
        {
            for (int j = 0; j < absDiffSeq.Length - 1; j++)
            {
                int currentDigit = absDiffSeq[j];
                int nextDigit = absDiffSeq[j + 1];

                bool isDiffCorrect = (currentDigit == (nextDigit + 1)) || currentDigit == nextDigit;

                if (currentDigit < nextDigit || !isDiffCorrect)
                {
                    return false;
                }
            }

            return true;
        }

        private static int AbsoluteDifference(int firstNumber, int secondNumber)
        {
            int diff = firstNumber - secondNumber;

            return Math.Abs(diff);
        }
    }
}
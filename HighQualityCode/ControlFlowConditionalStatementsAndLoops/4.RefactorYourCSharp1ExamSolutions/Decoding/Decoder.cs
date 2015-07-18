/* Telerik Academy Exam 1 @ 3 February 2015 Morning
    Original code (sent in BGCoder) for Task 2. Decoding:

    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            int salt = int.Parse(Console.ReadLine());
            string encodedText = Console.ReadLine();
            // StringBuilder originalText = new StringBuilder();
            int[] original = new int[encodedText.Length];
            char symbol;
            double[] finalText = new double[encodedText.Length];

            for (int i = 0; i < encodedText.Length; i++)
            {
                if (encodedText[i] == '@')
                {
                    break;
                }
                else if (Char.IsLetter(encodedText, i))
                {
                    symbol = (char)(encodedText[i] * salt);
                    //originalText.Append(symbol + 1000);
                    finalText[i] = (double)(symbol + 1000);
                }
                else if (Char.IsDigit(encodedText, i))
                {
                    symbol = (char)(encodedText[i] + salt);
                    // originalText.Append(symbol + 500);
                    finalText[i] = (symbol + 500);
                }
                else
                {
                    symbol = (char)(encodedText[i] - salt);
                    // originalText.Append(symbol);
                    finalText[i] = symbol;
                }

                if ((i % 2) == 0)
                {
                    finalText[i] /= 100;
                    Console.WriteLine("{0:F2}", finalText[i]);
                }
                else
                {
                    finalText[i] *= 100;
                    Console.WriteLine((int)finalText[i]);
                }

            }

            //for (int j = 0; j < originalText.Length; j++)
            //{
            //    if ((j % 2) == 0)
            //    {
            //        originalText[j] = (char)(originalText[j] / 100);
            //    }
            //    else
            //    {
            //        originalText[j] = (char)(originalText[j] * 100);
            //    }
            //}

        }
    }
*/

namespace Decoder
{
    using System;
    using System.Text;

    public class Decoder
    {
        public static void Main()
        {
            const char EndOfOriginalText = '@';

            int salt = int.Parse(Console.ReadLine());
            string originalText = Console.ReadLine();

            char symbol;
            double[] encodedText = new double[originalText.Length];

            for (int i = 0; i < originalText.Length; i++)
            {
                if (originalText[i] == EndOfOriginalText)
                {
                    break;
                }
                else if (char.IsLetter(originalText, i))
                {
                    symbol = (char)(originalText[i] * salt);
                    encodedText[i] = (double)(symbol + 1000);
                }
                else if (char.IsDigit(originalText, i))
                {
                    symbol = (char)(originalText[i] + salt);
                    encodedText[i] = symbol + 500;
                }
                else
                {
                    symbol = (char)(originalText[i] - salt);
                    encodedText[i] = symbol;
                }

                if ((i % 2) == 0)
                {
                    encodedText[i] /= 100;
                    Console.WriteLine("{0:F2}", encodedText[i]);
                }
                else
                {
                    encodedText[i] *= 100;
                    Console.WriteLine((int)encodedText[i]);
                }
            }
        }
    }
}
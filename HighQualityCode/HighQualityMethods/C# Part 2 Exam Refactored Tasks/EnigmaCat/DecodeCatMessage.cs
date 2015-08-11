namespace EnigmaCat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DecodeCatMessage
    {
        private static Dictionary<char, int> letterAndDigitPair = new Dictionary<char, int>();
            
        public static void Main()
        {
            string encodedMessage = Console.ReadLine();
            
            // Set dictionary
            letterAndDigitPair.Add('a', 0);
            letterAndDigitPair.Add('b', 1);
            letterAndDigitPair.Add('c', 2);
            letterAndDigitPair.Add('d', 3);
            letterAndDigitPair.Add('e', 4);
            letterAndDigitPair.Add('f', 5);
            letterAndDigitPair.Add('g', 6);
            letterAndDigitPair.Add('h', 7);
            letterAndDigitPair.Add('i', 8);
            letterAndDigitPair.Add('j', 9);
            letterAndDigitPair.Add('k', 10);
            letterAndDigitPair.Add('l', 11);
            letterAndDigitPair.Add('m', 12);
            letterAndDigitPair.Add('n', 13);
            letterAndDigitPair.Add('o', 14);
            letterAndDigitPair.Add('p', 15);
            letterAndDigitPair.Add('q', 16);
            letterAndDigitPair.Add('r', 17);
            letterAndDigitPair.Add('s', 18);
            letterAndDigitPair.Add('t', 19);
            letterAndDigitPair.Add('u', 20);
            letterAndDigitPair.Add('v', 21);
            letterAndDigitPair.Add('w', 22);
            letterAndDigitPair.Add('x', 23);
            letterAndDigitPair.Add('y', 24);
            letterAndDigitPair.Add('z', 25);

            string[] encodedMessageWords = encodedMessage.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // string[] words = new[] { "cb"};
            string[] decodedMessageWords = new string[encodedMessageWords.Length];
            long decimalNumber = 0;

            for (int i = 0; i < encodedMessageWords.Length; i++)
            {
                string word = encodedMessageWords[i];

                Convert17ToDecimal(word, ref decimalNumber);

                decodedMessageWords[i] = ConvertDecimalToOtherNumeralSystem(ref decimalNumber, 26);
            }

            string decodedMessage = string.Join(" ", decodedMessageWords);
            Console.WriteLine(decodedMessage);
        }

        private static string ConvertDecimalToOtherNumeralSystem(ref long decNum, int numeralSystem)
        {
            StringBuilder result = new StringBuilder();

            while (decNum > 0)
            {
                long remainder = decNum % numeralSystem;
                decNum /= numeralSystem;

                var currentLetter = letterAndDigitPair.FirstOrDefault(x => x.Value == remainder).Key;
                result.Append(currentLetter);
            }

            // Way to return reversed string from StringBuilder
            var resultToCharArr = result.ToString().Reverse().ToArray();
            return string.Join(string.Empty, resultToCharArr);
        }

        private static void Convert17ToDecimal(string word, ref long decimalNumber)
        {
            decimalNumber = 0;
            for (int j = 0; j < word.Length; j++)
            {
                char currentSymbol = word[j];

                decimalNumber *= 17;

                int currentDigit = letterAndDigitPair[currentSymbol];
                decimalNumber += currentDigit;
            }
        }
    }
}

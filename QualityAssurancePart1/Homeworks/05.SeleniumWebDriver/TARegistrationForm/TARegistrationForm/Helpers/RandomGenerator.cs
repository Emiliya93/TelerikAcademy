namespace TARegistrationForm.Helpers
{
    using System;

    public class RandomGenerator
    {
        private const string LatinLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        private const string CyrillicLetters = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯабвгдежзийклмнопрстуфхцчшщъьюя";

        private static RandomGenerator instance;

        private readonly Random random;

        private RandomGenerator()
        {
            this.random = new Random();
        }

        public static RandomGenerator Instance
        {
            get
            {
                return instance ?? (instance = new RandomGenerator());
            }
        }

        public int GetRandomNumber(int min, int max)
        {
            return this.random.Next(min, max + 1);
        }

        public string GetRandomStringLatinLetters(int length)
        {
            var chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                chars[i] = LatinLetters[this.GetRandomNumber(0, LatinLetters.Length - 1)];
            }

            return new string(chars);
        }

        public string GetRandomStringCyrillicLetters(int length)
        {
            var chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                chars[i] = CyrillicLetters[this.GetRandomNumber(0, CyrillicLetters.Length - 1)];
            }

            return new string(chars);
        }
    }
}

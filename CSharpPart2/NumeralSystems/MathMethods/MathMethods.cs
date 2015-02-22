namespace MathMethods
{
    using System;

    public class MathMethods
    {
        public static long NumberOnPower(long baseNumber, long power)
        {
            long numberOnPower = 1;

            for (int i = 0; i < power; i++)
            {
                numberOnPower *= baseNumber;
            }

            return numberOnPower;
        }
    }
}

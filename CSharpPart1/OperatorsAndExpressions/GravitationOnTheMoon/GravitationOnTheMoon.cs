using System;

/*
    Problem 2. Gravitation on the Moon

    The gravitational field of the Moon is approximately 17% of that on the Earth.
    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
*/
class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Enter your weight on Earth:");
        double weightOnEarth = double.Parse(Console.ReadLine());

        double weightOnMoon = weightOnEarth * (17.0 / 100.0);

        Console.WriteLine("Your weight on Moon is: {0}", weightOnMoon);
    }
}

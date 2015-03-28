namespace AnimalHierarchy
{
    using System;

    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, char gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Qwak!");
        }
    }
}
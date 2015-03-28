namespace AnimalHierarchy
{
    using System;

    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, char gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bau!");
        }
    }
}

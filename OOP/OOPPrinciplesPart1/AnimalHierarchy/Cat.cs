namespace AnimalHierarchy
{
    using System;

    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, char gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Myau!");
        }
    }
}

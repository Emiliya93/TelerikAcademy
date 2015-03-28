namespace AnimalHierarchy
{
    using System;

    public class Kitten : Cat, ISound
    {
        public Kitten(string name, int age, char gender)
            : base(name, age, gender)
        {
        }

        public override char Gender
        {
            get
            {
                return base.Gender;
            }

            protected set
            {
                if (value == 'm')
                {
                    throw new ArgumentException("Kitten cannot be male!");
                }

                base.Gender = value;
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Purmyau!");
        }
    }
}
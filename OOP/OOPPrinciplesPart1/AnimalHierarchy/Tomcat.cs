namespace AnimalHierarchy
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, char gender)
            : base (name, age, gender)
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
                if (value == 'f')
                {
                    throw new ArgumentException("Tomcat cannot be female!");
                }

                base.Gender = value;
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Murmyau!");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private char gender;

        public Animal(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                CheckName(value);

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                CheckIfValueLessThanZero(value, "Age cannot be less than zero!");

                this.age = value;
            }
        }

        public virtual char Gender
        {
            get
            {
                return this.gender;
            }

            protected set
            {
                this.gender = value;
            }
        }

        private void CheckName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("There must be a student's name!");
            }

            if (name.Any(ch => !char.IsLetter(ch) || char.IsWhiteSpace(ch)))
            {
                throw new ArgumentException("Name cannot have special symbols or white space!");
            }
        }

        public void CheckIfValueLessThanZero(int value, string message)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }

        //TODO: check how to inherit
        public abstract void ProduceSound();
    }
}

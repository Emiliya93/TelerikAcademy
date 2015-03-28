namespace StudentsAndWorkers
{
    using System;
    using System.Linq;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                CheckName(value);

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                CheckName(value);

                this.lastName = value;
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
    }
}
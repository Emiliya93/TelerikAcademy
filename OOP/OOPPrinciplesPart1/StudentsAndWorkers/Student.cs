namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                CheckIfValueLessThanZero(value, "Grade cannot be less than zero!");

                this.grade = value;
            }
        }

        public void CheckIfValueLessThanZero(int value, string message)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }
    }
}
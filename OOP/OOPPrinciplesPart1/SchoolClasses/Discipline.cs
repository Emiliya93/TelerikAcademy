namespace SchoolClasses
{
    using System;

    public class Discipline
    {
        private string name;

        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string Name
        {
            get 
            { 
                return this.name; 
            }

            private set
            {
                name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            private set
            {
                if (value == null || value < 0)
                {
                    throw new ArgumentException("Number of lectures cannot be null or less than zero!");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }

            private set
            {
                if (value == null || value < 0)
                {
                    throw new ArgumentException("Number of exercises cannot be null or less than zero!");
                }

                this.numberOfExercises = value;
            }
        }
    }
}

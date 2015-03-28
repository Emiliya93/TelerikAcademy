namespace SchoolClasses
{
    public class Student : Person
    {
        private StudentClass uniqueClassNumber;

        public Student(string name, StudentClass uniqueClassNumber)
            : base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public StudentClass UniqueClassNumber
        {
            get
            {
                return this.uniqueClassNumber;
            }

            private set
            {
                this.uniqueClassNumber = value;
            }
        }
    }
}

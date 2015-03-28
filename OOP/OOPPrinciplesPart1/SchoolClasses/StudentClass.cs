namespace SchoolClasses
{
    using System.Collections.Generic;

    public class StudentClass
    {
        private string uniqueTextID;
        private List<Teacher> teachers;

        public StudentClass(string uniqueTextID, List<Teacher> teachers)
        {
            this.UniqueTextID = uniqueTextID;
            this.Teachers = teachers;
        }

        public string UniqueTextID
        {
            get
            {
                return this.uniqueTextID;
            }

            private set
            {
                this.uniqueTextID = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return new List<Teacher>(this.teachers);
            }

            private set
            {
                //TODO: Check if here must be an exeption
                if (value == null)
                {
                    this.teachers = new List<Teacher>();
                }

                this.teachers = value;
            }
        }
    }
}

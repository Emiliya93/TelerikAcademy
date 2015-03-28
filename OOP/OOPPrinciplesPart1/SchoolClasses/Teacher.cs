namespace SchoolClasses
{
    using System.Collections.Generic;

    public class Teacher : Person
    {
        private List<Discipline> disciplines;

        public Teacher(string name, List<Discipline> disciplines)
            : base(name)
        {
            this.Disciplines = new List<Discipline>(disciplines);
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return new List<Discipline>(disciplines);
            }

            private set
            {
                this.disciplines = value;
            }
        }
    }
}

namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxStudentsCount = 30;
        private string name;
        private ICollection<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckIfNullOrEmpty(value, "Course's name");

                this.name = value;
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }

            private set
            {
                this.students = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student to add cannot be null.");
            }

            if (this.students.Count + 1 > Course.MaxStudentsCount)
            {
                throw new InvalidOperationException("Students course is full.");
            }

            if (this.students.Contains(student))
            {
                throw new InvalidOperationException("This student is already in the course.");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student to remove cannot be null.");
            }

            if (!this.students.Contains(student))
            {
                throw new InvalidOperationException("The student is not in the course.");
            }

            this.students.Remove(student);
        }

        public int StudentsCount()
        {
            return this.students.Count;
        }
    }
}

using System;
namespace School
{
    public class Student
    {
        private const int MinIdValue = 10000;
        private const int MaxIdValue = 99999;

        private string name;
        private int id;

        /// <summary>
        /// Creating student
        /// </summary>
        /// <param name="name">The student name.</param>
        /// <param name="id">The student's id. Must be between 10000 and 99999.</param>
        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckIfNullOrEmpty(value, "Student's name");

                this.name = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                Validator.CheckIfValidID(value, MinIdValue, MaxIdValue);

                this.id = value;
            }
        }

        public void JoinCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course to join cannot be null!");
            }

            course.AddStudent(this);
        }

        public void LeaveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course to leave cannot be null!");
            }

            course.RemoveStudent(this);
        }
    }
}

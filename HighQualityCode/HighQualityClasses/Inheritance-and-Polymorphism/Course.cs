namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Abstract base class for common properties for courses.
    /// </summary>
    public abstract class Course
    {
        /// <summary>
        /// Encapsulated private field for course name.
        /// </summary>
        private string courseName;

        /// <summary>
        /// Encapsulated private field for teacher name.
        /// </summary>
        private string teacherName;

        /// <summary>
        /// Encapsulated private field for students in the course.
        /// </summary>
        private IList<string> students;

        /// <summary>
        /// Initializes a new instance of the <see cref="Course"/> class, that creates an instance with set course name.
        /// </summary>
        /// <param name="courseName">The name of the current course.</param>
        protected Course(string courseName)
        {
            this.CourseName = courseName;
            this.TeacherName = null;
            this.Students = new List<string>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Course"/> class, that creates an instance with set course and teacher name.
        /// </summary>
        /// <param name="courseName">The name of the current course.</param>
        /// <param name="teacherName">The name of the current course teacher.</param>
        protected Course(string courseName, string teacherName)
            : this(courseName)
        {
            this.TeacherName = teacherName;
            this.Students = new List<string>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Course"/> class, that creates an instance with set course and teacher name and list of students in it.
        /// </summary>
        /// <param name="courseName">The name of the current course.</param>
        /// <param name="teacherName">The name of the current course teacher.</param>
        /// <param name="students">The list of the students in the course.</param>
        protected Course(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName)
        {
            this.Students = students;
        }

        /// <summary>
        /// Gets the course name of the instance.
        /// </summary>
        public string CourseName
        {
            get
            {
                return this.courseName;
            }

            private set
            {
                this.CheckIfNullOrEmpty(value);
                this.courseName = value;
            }
        }

        /// <summary>
        /// Gets or sets the teacher name of the instance.
        /// </summary>
        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                this.teacherName = value;
            }
        }

        /// <summary>
        /// Gets or sets the list of students of the instance.
        /// </summary>
        public IList<string> Students
        {
            get
            {
                return new List<string>(this.students);
            }

            set 
            {
                if (value == null)
                {
                    this.students = new List<string>();
                }
                else
                {
                    this.students = value;
                }
            }
        }

        /// <summary>
        /// Overrides the object ToString method to return a string with all the information provided about the course.
        /// </summary>
        /// <returns>The course information as a string.</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("OffsiteCourse { Name = ");
            result.Append(this.CourseName);

            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }

        /// <summary>
        /// Returns the list of the students as string, surrounded in curly brackets.
        /// </summary>
        /// <returns>String with the students.</returns>
        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        /// <summary>
        /// Checks if the specified string is null or empty and throws an exception if it does.
        /// </summary>
        /// <param name="value">The string to be checked.</param>
        /// <exception cref="ArgumentNullException">Course name cannot be null or empty.</exception>
        private void CheckIfNullOrEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Course name cannot be null or empty!");
            }
        }
    }
}

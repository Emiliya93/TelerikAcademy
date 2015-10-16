using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void CreatingValidCourseShouldNotThrow()
        {
            Course course = new Course("Math");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatingCourseWithNullForNameShouldThrow()
        {
            Course course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatingCourseWithEmptyNameShouldThrow()
        {
            Course course = new Course(string.Empty);
        }

        [TestMethod]
        public void CourseShouldReturnExpectedName()
        {
            string name = "Math";
            Course course = new Course(name);

            string courseName = course.Name;

            Assert.AreEqual(name, courseName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingNullStudentShouldThrow()
        {
            Course course = new Course("Math");

            course.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingExistingStudentShouldThrow()
        {
            Course course = new Course("Math");
            Student student = new Student("Smiley", 10123);
            course.AddStudent(student);

            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemovingNullStudentShouldThrow()
        {
            Course course = new Course("Math");

            course.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemovingNonExistingStudentShouldThrow()
        {
            Course course = new Course("Math");
            Student student = new Student("Smiley", 10123);

            course.RemoveStudent(student);
        }

        [TestMethod]
        public void AddingValidStudentShouldNotThrow()
        {
            Course course = new Course("Math");
            Student student = new Student("Smiley", 10123);
            course.AddStudent(student);
        }

        [TestMethod]
        public void RemovingExistingStudentShouldNotThrow()
        {
            Course course = new Course("Math");
            Student student = new Student("Smiley", 10123);
            course.AddStudent(student);

            course.RemoveStudent(student);
        }

        [TestMethod]
        public void AddingOneValidStudentShouldHaveCount1()
        {
            Course course = new Course("Math");
            Student student = new Student("Smiley", 10123);
            course.AddStudent(student);

            int expectedCount = 1;
            int actualCount = course.StudentsCount();

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void AddingOneValidStudentAndRemovingItShouldHaveCount0()
        {
            Course course = new Course("Math");
            Student student = new Student("Smiley", 10123);
            course.AddStudent(student);
            course.RemoveStudent(student);

            int expectedCount = 0;
            int actualCount = course.StudentsCount();

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void Adding30ValidStudentsShouldHaveCount30()
        {
            Course course = new Course("Math");

            for (int i = 0; i < 30; i++)
            {
                Student student = new Student(string.Format("Smiley #{0}", i), 10000 + i);
                course.AddStudent(student);
            }


            int expectedCount = 30;
            int actualCount = course.StudentsCount();

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Adding31ValidStudentsShouldThrow()
        {
            Course course = new Course("Math");

            for (int i = 0; i < 31; i++)
            {
                Student student = new Student(string.Format("Smiley #{0}", i), 10000 + i);
                course.AddStudent(student);
            }
        }
    }
}

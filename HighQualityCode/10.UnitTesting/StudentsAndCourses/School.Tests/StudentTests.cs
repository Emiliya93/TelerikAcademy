namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void CreatingValidStudentShouldNotThrow()
        {
            Student student = new Student("Smiley Cuoco", 12101);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatingStudentWithNullForNameShouldThrow()
        {
            Student student = new Student(null, 12101);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatingStudentWithEmptyNameShouldThrow()
        {
            Student student = new Student(string.Empty, 12101);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreatingStudentWithShortIDShouldThrow()
        {
            Student student = new Student("Smiley Cuoco", 121);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreatingStudentWithLongIDShouldThrow()
        {
            Student student = new Student("Smiley Cuoco", 121123);
        }

        [TestMethod]
        public void StudentShouldReturnExpectedName()
        {
            string name = "Smiley Cuoco";
            Student student = new Student(name, 12101);

            string studentName = student.Name;

            Assert.AreEqual(name, studentName);
        }

        [TestMethod]
        public void StudentShouldReturnExpectedID()
        {
            string name = "Smiley Cuoco";
            int id = 12101;
            Student student = new Student(name, id);

            int studentId = student.Id;

            Assert.AreEqual(id, studentId);
        }
    }
}

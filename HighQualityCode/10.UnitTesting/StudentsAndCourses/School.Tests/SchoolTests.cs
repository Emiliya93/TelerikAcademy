using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void CreatingValidSchoolShouldNotThrow()
        {
            School school = new School("151 NSOU");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatingSchoolWithNullForNameShouldThrow()
        {
            School school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatingSchoolWithEmptyNameShouldThrow()
        {
            School school = new School(string.Empty);
        }

        [TestMethod]
        public void SchoolShouldReturnExpectedName()
        {
            string name = "151 NSOU";
            School school = new School("151 NSOU");

            string schoolName = school.Name;

            Assert.AreEqual(name, schoolName);
        }


    }
}

namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    class Tests
    {
        static void Main()
        {
            //List<Discipline> disciplenes = new List<Discipline>()
            //{
            //    new Discipline("Mathematics", 4, 6),

            //}

            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher("Katq Todorova", new List<Discipline>(){ new Discipline("Mathematics", 4, 6), new Discipline("Physics", 4, 5) }),
                new Teacher("Mariq Pindeva", new List<Discipline>(){ new Discipline("Chemistry", 2,1) })
            };

            List<Student> students = new List<Student>()
            {
                new Student("Ivan Petrov", new StudentClass("58", teachers)),
                new Student("Vasilka Mladenova", new StudentClass("57", teachers))
            };

        }
    }
}
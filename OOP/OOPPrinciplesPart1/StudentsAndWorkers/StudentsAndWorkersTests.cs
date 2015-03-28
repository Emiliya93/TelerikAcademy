namespace StudentsAndWorkers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StudentsAndWorkersTests
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
                {
                    new Student("Sara", "Elisondo", 3),
                    new Student("Norma", "Rayes", 5),
                    new Student("Huan", "Rayes", 6),
                    new Student("Martin", "Donches", 4),
                    new Student("Panchita", "Rodriges", 6),
                    new Student("Panchita", "Rodriges", 4),
                    new Student("Panchita", "Rodriges", 5),
                    new Student("Panchita", "Rodriges", 3),
                    new Student("Panchita", "Rodriges", 5),
                    new Student("Ponyta", "Rodriges", 2),
                };

            var sortedStudents = students.OrderBy(st => st.Grade);

            Console.WriteLine("Sorted students:".ToUpper());
            Console.WriteLine();

            foreach (Student student in sortedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + "->" + student.Grade);
            }

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Pesho", "Petrov", 500, 8),
                new Worker("Maria", "Mihailova", 460, 4),
                new Worker("Smiley", "Kuako", 820, 12),
                new Worker("Panchita", "Rodriges", 500, 12),
                new Worker("Ponyta", "Rodriges", 460, 12),
                new Worker("Martin", "Rodriges", 120, 4),
                new Worker("Huan", "Rayes", 250, 8),
                new Worker("Norma", "Rayes", 500, 6),
                new Worker("Gabriela", "Elisondo", 500, 12),
                new Worker("Eva", "Monches", 500, 12),
            };

            var sortedWorkers = workers.OrderByDescending(w => w.MoneyPerHour());

            Console.WriteLine();
            Console.WriteLine("Sorted workers:".ToUpper());
            Console.WriteLine();

            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker.FirstName + " " + worker.LastName);
                Console.WriteLine("Week salary: {0}; Work hours per day: {1}; Money per hour: {2}", worker.WeekSalary, worker.WorkHoursPerDay, worker.MoneyPerHour());
                Console.WriteLine();
            }

            List<Human> mergedAndSorted = students.Concat<Human>(workers).OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
        }
    }
}
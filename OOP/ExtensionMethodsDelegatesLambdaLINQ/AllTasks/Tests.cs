namespace AllTasks
{
    using System;
    using System.Text;
    using AllTasks.ExtensionMethods;
    using System.Collections.Generic;
    using System.Linq;

    class Tests
    {
        const int startAge = 18;
        const int endAge = 24;

        static List<int> listOfInts = new List<int>() { 7, 35, 3, 21, 56, 42, 5, 126, 1 };

        const int firstNumber = 3;
        const int secondNumber = 7;

        static List<Student> students = new List<Student>()
            {
                new Student("Smiley", "Nonsense", "111213006", "029868877", "smiley@abv.bg", 21, new List<double>(){2, 3, 4, 5, 5, 5, 6}, 2, "Mathematics"),
                new Student("Pesho", "Peshev", "11213002", "027896532", "peshko@abv.bg", 20, new List<double>(){3, 3, 4, 3, 5, 4}, 5, "Mathematics"),
                new Student("Angel", "Mishev", "111213003", "042632312", "acho@mail.com", 18, new List<double>(){6, 6, 4, 5, 6, 5}, 4, "Chemistry"),
                new Student("Lindsey", "Monkey", "111213006", "069453621", "lindy@gmail.com", 21, new List<double>(){4, 5, 6, 2, 6, 3}, 2, "Physics"),
                new Student("Lindsey", "Ponkey", "111213004", "069453621", "lindy@gmail.com", 21, new List<double>(){2, 3, 2, 5, 4, 3}, 2, "Mathematics")
            };

        static readonly string separator = new string('*', 120);

        static int maxLenght = 0;

        static void Main()
        {
            // 01. StringBuilder.Substring
            //StringBuilderTest();

            // 02. IEnumerable extensions
            //EnumerableTests();

            // 03. First before last
            //FirstNameBeforeLast(students);

            // 04. Age range
            //StudentsWithGivenAge(students);

            // 05. Order students
            //SortWithLINQ(students);

            //SortWithLambda(students);

            // 06. Divisible by 7 and 3
            //PrintNumbers();
            //NumbersDivisibleWithLINQ();

            //NumbersDivisibleWithLambda();

            // 07. Timer

            // 08.* Events

            // 09. Student groups
            //OrderByFirstNameGroupNumber2LINQ();

            // 10. Student groups extensions
            //OrderByFirstNameGroupNumber2Lambda();

            // 11. Extract students by email
            //ExtractStudentsByEmail();

            // 12. Extract students by phone
            //ExtractStudentsByPhone();

            // 13. Extract students by marks
            //ExtractStudentsByMarks();

            // 14. Extract students with two marks
            //ExtractStudentsWithTwoMarks2();

            // 15. Extract marks
            //ExtractStudentMarksFrom2006();

            // 17. Longest string
            //string[] strings = new string[]
            //{
            //    "Smiley",
            //    "Sabaton",
            //    "Mo",
            //    "Kindsley"
            //};
            //Console.WriteLine("My strings:".ToUpper());
            //Console.WriteLine();
            //strings.ForEach(Console.WriteLine);
            //Console.WriteLine("Longest string:".ToUpper());
            //Console.WriteLine();
            //Console.WriteLine(FindLongestString(strings));

            // 18. Grouped by GroupNumber
            //GroupedByGroupNumberLINQ();

            // 19. Grouped by GroupName extensions
            //GroupedByGroupNumberLambda();
        }

        private static string FindLongestString(string[] strings)
        {
            string longest = strings.Where(str => IsLongest(str)).Last();

            return longest;
        }

        private static bool IsLongest(string str)
        {
            if (str.Length > maxLenght)
            {
                maxLenght = str.Length;
                return true;
            }
            else
            {
                return false;
            }
        }


        private static void StringBuilderTest()
        {
            StringBuilder text = new StringBuilder();

            text.Append("Smiley");

            Console.WriteLine("Text:");
            Console.WriteLine(text);
            Console.WriteLine("Substring from index 1:");
            Console.WriteLine(text.Substring(1));
            Console.WriteLine("Substring from index 1 and lenght 3:");
            Console.WriteLine(text.Substring(1, 3));
        }

        private static void EnumerableTests()
        {
            Console.Write("Sum: ");
            Console.WriteLine(listOfInts.Sum());
            Console.Write("Product: ");
            Console.WriteLine(listOfInts.Product());
            Console.Write("Max: ");
            Console.WriteLine(listOfInts.Max());
            Console.Write("Min: ");
            Console.WriteLine(listOfInts.Min());
            Console.Write("Average: ");
            Console.WriteLine(listOfInts.Average());
        }

        private static void FirstNameBeforeLast(List<Student> students)
        {
            Console.WriteLine(separator);
            Console.WriteLine("Students with first name before last name:".ToUpper());
            Console.WriteLine();

            var firstNameBeforeLast = from student in students
                                      where string.Compare(student.FirstName, student.LastName, true) < 0
                                      select student;

            firstNameBeforeLast.ForEach(Console.WriteLine);
            Console.WriteLine(separator);
        }
 
        private static void StudentsWithGivenAge(List<Student> students)
        {
            Console.WriteLine(separator);
            Console.WriteLine("Students with age between {0} and {1}:".ToUpper(), startAge, endAge);
            Console.WriteLine();

            var studentsWithAge = from student in students
                                  where student.Age > startAge && student.Age < endAge
                                  select new Student(student.FirstName, student.LastName, student.Age);

            studentsWithAge.ForEach(Console.WriteLine);
            Console.WriteLine(separator);
        }

        private static void SortWithLINQ(List<Student> students)
        {
            Console.WriteLine("Students sorted by first name then by last name in descending order (with lambda):".ToUpper());
            Console.WriteLine();

            var sortedStudents = from student in students
                                 orderby student.FirstName descending, student.LastName descending
                                 select student;

            sortedStudents.ForEach(Console.WriteLine);
            Console.WriteLine(separator);
        }
      
        private static void SortWithLambda(List<Student> students)
        {
            Console.WriteLine("Students sorted by first name then by last name in descending order (with LINQ):".ToUpper());
            Console.WriteLine();


            var sortedStudents = students.OrderByDescending(st => st.FirstName)
                                         .ThenByDescending(st => st.LastName);

            sortedStudents.ForEach(Console.WriteLine);
            Console.WriteLine(separator);
        }

        private static void PrintNumbers()
        {
            Console.WriteLine(separator);
            Console.WriteLine("Numbers:".ToUpper());
            Console.WriteLine();
            listOfInts.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine(separator);
        }

        private static void NumbersDivisibleWithLINQ()
        {
            Console.WriteLine(separator);
            Console.WriteLine("Numbers divisible by 7 and 3 (with lambda)".ToUpper());
            Console.WriteLine();

            var divisibleNumbers = from num in listOfInts
                                   where num % firstNumber == 0 && num % secondNumber == 0
                                   select num;

            divisibleNumbers.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine(separator);
        }

        private static void NumbersDivisibleWithLambda()
        {
            Console.WriteLine(separator);
            Console.WriteLine("Numbers divisible by 7 and 3 (with LINQ)".ToUpper());
            Console.WriteLine();

            var divisibleNumbers = listOfInts.Where(x => (x % firstNumber == 0) && (x % secondNumber == 0));

            divisibleNumbers.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine(separator);
        }

        private static void OrderByFirstNameGroupNumber2LINQ()
        {
            Console.WriteLine(separator);
            Console.WriteLine("Students ordered by group 2 and first name (with LINQ)".ToUpper());
            Console.WriteLine();

            var sortedStuds = from st in students
                              orderby st.FirstName
                              where st.GroupNumber == 2
                              select st;

            sortedStuds.ForEach(Console.WriteLine);
            Console.WriteLine(separator);
        }

        private static void OrderByFirstNameGroupNumber2Lambda()
        {
            Console.WriteLine(separator);
            Console.WriteLine("Students ordered by group 2 and first name (with Lambda)".ToUpper());
            Console.WriteLine();

            var sortedStuds = students.Where(st => st.GroupNumber == 2)
                                      .OrderBy(st => st.FirstName);

            sortedStuds.ForEach(Console.WriteLine);
            Console.WriteLine(separator);
        }

        private static void ExtractStudentsByEmail()
        {
            Console.WriteLine(separator);
            Console.WriteLine("Students ordered by email at abv.bg:".ToUpper());
            Console.WriteLine();

            //var studByEmail = from st in students
            //                  where st.Email.ToString().EndsWith("abv.bg")
            //                  select st;

            var studByEmail = from st in students
                              where st.Email.Host == "abv.bg"
                              select st;

            studByEmail.ForEach(Console.WriteLine);
            Console.WriteLine(separator);
        }

        private static void ExtractStudentsByPhone()
        {
            Console.WriteLine(separator);
            Console.WriteLine("Students ordered by email at abv.bg:".ToUpper());
            Console.WriteLine();

            var studs = from st in students
                        where st.Phone.StartsWith("02") || st.Phone.StartsWith("+3592")
                        select st;

            studs.ForEach(Console.WriteLine);
            Console.WriteLine(separator);
        }

        private static void ExtractStudentsByMarks()
        {
            Console.WriteLine(separator);
            Console.WriteLine("Students with mark 6".ToUpper());
            Console.WriteLine();

            var studs = from st in students
                        where st.Marks.Contains(6)
                        select new
                        {
                            FullName = st.FirstName + " " + st.LastName,
                            Marks = st.Marks
                        };

            foreach (var st in studs)
            {
                Console.WriteLine(st.FullName);
                Console.WriteLine(string.Join(", ", st.Marks));
                Console.WriteLine();
            }

            Console.WriteLine(separator);
        }

        private static void ExtractStudentsWithTwoMarks2()
        {
            Console.WriteLine(separator);
            Console.WriteLine("Students with exactly two marks 2".ToUpper());
            Console.WriteLine();

            var studs = students.Where(st => st.Marks.FindAll(x => x == 2).Count == 2);

            studs.ForEach(Console.WriteLine);
        }

        private static void ExtractStudentMarksFrom2006()
        {
            Console.WriteLine(separator);
            Console.WriteLine("Students marks from 2006".ToUpper());
            Console.WriteLine();

            var stud = students.Where(st => st.FacultyNumber.EndsWith("06"))
                               .Select(st => new { FullName = st.FirstName + " " + st.LastName, Marks = st.Marks});

            stud.ForEach(st => Console.WriteLine(st.FullName + ": " + string.Join(", ", st.Marks)));
        }

        private static void GroupedByGroupNumberLINQ()
        {
            var studs = from st in students
                        group st by st.GroupNumber into newGroup
                        orderby newGroup.Key
                        select newGroup;

            foreach (var group in studs)
            {
                Console.WriteLine(separator);
                Console.Write("GROUP ");
                Console.WriteLine(group.Key + ":");
                Console.WriteLine();
                foreach (var st in group)
                {
                    Console.WriteLine(st);
                }
            }
        }

        private static void GroupedByGroupNumberLambda()
        {
            var studs = students.GroupBy(st => st.GroupNumber)
                                .OrderBy(gr => gr.Key);

            foreach (var group in studs)
            {
                Console.WriteLine(separator);
                Console.Write("GROUP ");
                Console.WriteLine(group.Key + ":");
                Console.WriteLine();
                foreach (var st in group)
                {
                    Console.WriteLine(st);
                }
            }
        }

    }
}

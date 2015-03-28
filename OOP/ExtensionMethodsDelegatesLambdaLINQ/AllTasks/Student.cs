namespace AllTasks
{
    using System;
    using System.Collections.Generic;
    using System.Net.Mail;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Linq;

    public class Student : Group
    {
        // Fields
        private string firstName;
        private string lastName;
        private string facultyNumber;
        private string phone;
        private MailAddress email;
        private List<double> marks;
        bool isMarksListSet;
        private int age;

        // Constructors
        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Student(string firstName, string lastName, string facultyNumber, string phone, string email, int age, List<double> marks, int groupNumber, string departmentName)
            : this(firstName, lastName, age)
        {
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = new MailAddress(email);
            this.Marks = new List<double>(marks);
            isMarksListSet = true;
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }

        // Properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                CheckName(value);

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                CheckName(value);

                this.lastName = value;
            }
        }
        //TODO: Check faculty number and phone
        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            private set
            {
                this.facultyNumber = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            private set
            {
                this.phone = value;
            }
        }

        public MailAddress Email
        {
            get
            {
                return this.email;
            }

            private set
            {
                CheckEmail(value.Address);

                this.email = value;
            }
        }

        public List<double> Marks
        {
            get
            {
                return new List<double>(this.marks);
            }
            private set
            {
                this.marks = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                CheckAge(value);

                this.age = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Group number cannot be less or equal to zero!");
                }

                this.groupNumber = value;
            }
        }

        public string DepartmentName
        {
            get
            {
                return this.departmentName;
            }
            private set
            {
                this.departmentName = value;
            }
        }

        // Methods
        private void CheckName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("There must be a student's name!");
            }
            if (name.Any(ch => !char.IsLetter(ch) || char.IsWhiteSpace(ch)))
            {
                throw new ArgumentException("Name cannot have special symbols or white space!");
            }
        }

        private void CheckEmail(string email)
        {
            if (!Regex.IsMatch(email.Trim(),
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                throw new ArgumentException("Invalid email!");
            }
        }

        private void CheckAge(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid age!");
            }
            else if (value < 18)
            {
                throw new ArgumentOutOfRangeException("Age of student cannot be less than 18!");
            }
        }

        public void AddMark(double mark)
        {
            this.marks.Add(mark);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0, -16}", "First name: ");
            sb.AppendLine(this.FirstName == null ? "No information" : this.FirstName);

            sb.AppendFormat("{0, -16}", "Last name: ");
            sb.AppendLine(this.LastName == null ? "No information" : this.lastName);

            if (this.FacultyNumber != null)
            {
                sb.AppendFormat("{0, -16}", "Faculty number: ");
                sb.AppendLine(this.FacultyNumber);
            }

            if (this.Phone != null)
            {
                sb.AppendFormat("{0, -16}", "Phone: ");
                sb.AppendLine(this.Phone);
            }

            if (this.Email != null)
            {
                sb.AppendFormat("{0, -16}", "Email: ");
                sb.AppendLine(this.Email.ToString());
            }

            if (this.Age.ToString() != null)
            {
                sb.AppendFormat("{0, -16}", "Age");
                sb.AppendLine(this.Age.ToString());
            }

            if (this.isMarksListSet)
            {
                sb.AppendFormat("{0, -16}", "Marks:");
                sb.AppendLine(string.Join(", ", this.Marks));
            }

            if (this.GroupNumber.ToString() != null)
            {
                sb.AppendFormat("{0, -16}", "Group number");
                sb.AppendLine(this.GroupNumber.ToString());
            }

            if (this.DepartmentName != null)
            {
                sb.AppendFormat("{0, -16}", "Department: ");
                sb.AppendLine(this.DepartmentName);
            }

            return sb.ToString();
        }
    }
}
namespace StudentsAndWorkers
{
    using System;

    class Worker : Human
    {
        private const int workDays = 5;

        private int weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            private set
            {
                CheckIfValueLessThanZero(value, "Week salary cannot be less than zero!");

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            private set
            {
                CheckIfValueLessThanZero(value, "Work hours per day cannot be less than zero!");
                
                this.workHoursPerDay = value;
            }
        }

        public void CheckIfValueLessThanZero(int value, string message)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }

        public int MoneyPerHour()
        {
            return (this.weekSalary / workDays) / this.workHoursPerDay;
        }
    }
}
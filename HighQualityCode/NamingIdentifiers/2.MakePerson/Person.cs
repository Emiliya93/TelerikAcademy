namespace MakePerson
{
    public class Person
    {
        public Person(int age)
        {
            this.Age = age;
            this.SetNameAndGender(this.Age);
        }

        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        private void SetNameAndGender(int age)
        {
            if (age % 2 == 0)
            {
                this.Name = "Батката";
                this.Gender = Gender.Male;
            }
            else
            {
                this.Name = "Мацето";
                this.Gender = Gender.Female;
            }
        }
    }
}

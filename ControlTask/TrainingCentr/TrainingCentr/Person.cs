using System;

namespace TrainingCentr
{
    public abstract class Person
    {
        protected string lastName;
        protected DateTime birthDate;

        public Person(string lastName, DateTime birthDate)
        {
            this.lastName = lastName;
            this.birthDate = birthDate;
        }
        public string LastName
        {
            get { return lastName; }
        }
        public DateTime BirthDate
        {
            get { return birthDate; }
        }
        public int CalculateAge()
        {
            return DateTime.Now.Year - birthDate.Year - (DateTime.Now.DayOfYear < birthDate.DayOfYear ? 1 : 0);
        }
        public abstract void Show();
    }
    public interface IEmployee
    {
        double CalculateSalary();
        int CalculateWorkExperience();
    }

}

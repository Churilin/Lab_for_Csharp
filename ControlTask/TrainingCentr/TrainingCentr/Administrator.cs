using System;

namespace TrainingCentr
{
    public class Administrator : Person, IEmployee
    {
        private string lab;

        public Administrator(string lastName, DateTime birthDate, string lab) : base(lastName, birthDate)
        {
            this.lab = lab;
        }
        public string Lab
        {
            get { return lab; }
        }
        public override void Show()
        {
            Console.WriteLine("Администратор:\n Фамилия: {0}\n Дата рождения: {1}\n Лаборатория: {2}\n Стаж: {3} лет",
                LastName, BirthDate.ToShortDateString(), Lab, CalculateWorkExperience());
        }
        public double CalculateSalary()
        {
            return 76000;
        }
        public int CalculateWorkExperience()
        {
            return 7;
        }
    }
}

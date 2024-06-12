using System;

namespace TrainingCentr   
{
    public class Manager : Person, IEmployee
    {
        private string faculty;
        private string position;
        public Manager(string lastName, DateTime birthDate, string faculty, string position)
            : base(lastName, birthDate)
        {
            this.faculty = faculty;
            this.position = position;
        }
        public string Faculty
        {
            get { return faculty; }
        }
        public string Position
        {
            get { return position; }
        }
        public override void Show()
        {
            Console.WriteLine("Менеджер:\n Фамилия: {0}\n Дата рождения: {1}\n Факультет: {2}\n Должность: {3}",
                LastName, BirthDate.ToShortDateString(), Faculty, Position);
        }
        public double CalculateSalary()
        {
            return 82000;
        }
        public int CalculateWorkExperience()
        {
            return DateTime.Now.Year - birthDate.Year - (DateTime.Now.DayOfYear < birthDate.DayOfYear ? 1 : 0);
        }
    }
}

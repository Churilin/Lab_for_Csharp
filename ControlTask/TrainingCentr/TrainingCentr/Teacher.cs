using System;

namespace TrainingCentr
{
    public class Teacher : Person, IEmployee
    {
        private string faculty;
        private string position;
        private int experience;

        public Teacher(string lastName, DateTime birthDate, string faculty, string position, int experience)
            : base(lastName, birthDate)
        {
            this.faculty = faculty;
            this.position = position;
            this.experience = experience;
        }
        public string Faculty
        {
            get { return faculty; }
        }
        public string Position
        {
            get { return position; }
        }
        public int Experience
        {
            get { return experience; }
        }
        public override void Show()
        {
            Console.WriteLine("Преподаватель:\n Фамилия: {0}\n Дата рождения: {1}\n Факультет: {2}\n Должность: {3}\n Стаж: {4} года",
                LastName, BirthDate.ToShortDateString(), Faculty, Position, CalculateWorkExperience());
        }
        public double CalculateSalary()
        {
            return 110000 + 1000 * Experience;
        }
        public int CalculateWorkExperience()
        {
            int ageAtStartOfWork = 25;
            int currentAge = DateTime.Now.Year - birthDate.Year - (DateTime.Now.DayOfYear < birthDate.DayOfYear ? 1 : 23);
            int workExperience = currentAge >= ageAtStartOfWork ? currentAge - ageAtStartOfWork + experience : 0;
            return workExperience;
        }
    }
}

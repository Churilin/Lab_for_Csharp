using System;

namespace TrainingCentr
{
    public class Student : Person
    {
        private string faculty;
        private string group;
        private int courseInfo;

        public Student(string lastName, DateTime birthDate, string faculty, string group, int courseInfo)
            : base(lastName, birthDate)
        {
            this.faculty = faculty;
            this.group = group;
            this.courseInfo = courseInfo;
        }
        public string Faculty
        {
            get { return faculty; }
        }
        public string Group
        {
            get { return group; }
        }
        public int CourseInfo
        {
            get { return courseInfo; }
        }
        public string GetCourseInfoInWords()
        {
            return $"{courseInfo}-й";
        }
        public override void Show()
        {
            Console.WriteLine("Студент:\n Фамилия: {0}\n Дата рождения: {1}\n Факультет: {2}\n Группа: {3}\n Курс обучения: {4}",
                LastName, BirthDate.ToShortDateString(), Faculty, Group, GetCourseInfoInWords());
        }
    }
}
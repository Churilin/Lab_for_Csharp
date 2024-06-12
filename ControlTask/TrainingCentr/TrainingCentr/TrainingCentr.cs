using System;
using System.Collections.Generic;

namespace TrainingCentr
{
    class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            people.Add(new Administrator("Афанасьев", new DateTime(1982, 3, 18), "Лаборатория 4"));
            people.Add(new Student("Синицын", new DateTime(2003, 8, 2), "Экономический", "А504/2", 2));
            people.Add(new Teacher("Воронцов", new DateTime(1976, 5, 22), "Кибернетический", "Доцент", 23));
            people.Add(new Manager("Павлов", new DateTime(1989, 7, 15), "Исторический", "Старший специалист"));

            foreach (Person person in people)
            {
                person.Show();
                if (person is IEmployee employee)
                {
                    Console.WriteLine("Заработная плата: {0}", employee.CalculateSalary());
                }
                Console.WriteLine();
            }
        }
    }
}
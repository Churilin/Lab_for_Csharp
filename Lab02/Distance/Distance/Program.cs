using System;

namespace Distance
{
    class Distance
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите футы: ");
            int feet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите дюймы: ");
            int inches = Convert.ToInt32(Console.ReadLine());
            int totalInches = feet * 12 + inches;
            int totalFeet = totalInches / 12;
            int otherInches = totalInches % 12;
            Console.WriteLine($"Сумма: {totalFeet}'-{otherInches}\"");
        }
    }
}
using System;

namespace Distance
{
    public struct DistanceStruct
    {
        public int Feet;
        public int Inches;
    }
    internal class Distance
    {
        static void Main()
        {
            DistanceStruct distance1;
            distance1.Feet = 15;
            distance1.Inches = 8;
            Console.WriteLine(distance1.Feet + "'-" + distance1.Inches + "\"");

            Console.WriteLine("Введите футы: ");
            int feet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите дюймы: ");
            int inches = Convert.ToInt32(Console.ReadLine());

            DistanceStruct distance2;
            distance2.Feet = feet;
            distance2.Inches = inches;

            DistanceStruct distance3 = SumDistances(distance1, distance2);
            Console.WriteLine($"Сумма: {distance3.Feet}'-{distance3.Inches}\"");
        }
         static DistanceStruct SumDistances(DistanceStruct distance1, DistanceStruct distance2)
        {
            DistanceStruct distance3;
            distance3.Feet = distance1.Feet + distance2.Feet;
            distance3.Inches = distance1.Inches + distance2.Inches;

            if (distance3.Inches >= 12)
            {
                distance3.Feet += distance3.Inches / 12;
                distance3.Inches %= 12;
            }

            return distance3;
        }
    }
}

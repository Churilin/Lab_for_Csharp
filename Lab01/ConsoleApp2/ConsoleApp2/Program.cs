using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста, введите первое значение");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите второе значение");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите третье значение");
            double c = Double.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Площадь треугольника равна:{0:#.##}", s);

            Console.WriteLine("Пожалуйста, введите значение периметра треугольника");
            double x1 = Double.Parse(Console.ReadLine());
            double x2 = x1 / 3;
            double x3 = x1 / 2;
            double x4 = Math.Sqrt(x3 * (x3 - x2) * (x3 - x2) * (x3 - x2));
            Console.WriteLine("Сторона треугольника равна:{0:#.##}", x2);
            Console.WriteLine("Площадь треугольника равна:{0:#.##}", x4);
        }
    }
}

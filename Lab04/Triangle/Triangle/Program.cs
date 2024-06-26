﻿using System;

namespace Triangle
{
    public class Operation
    {
        public static double TriangleArea(double a, double b, double c)
        {
            if (!IsTriangle(a, b, c))
            {
                throw new ArgumentException("Треугольник не определен");
            }
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public static double TriangleArea(double a)
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(a, 2);
        }

        private static bool IsTriangle(double a, double b, double c)
        {
            return a + b > c && b + c > a && c + a > b;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Если треугольник равносторонний - нажмите 1, если нет - нажмите 2");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Пожалуйста, введите значение:");
                double value = double.Parse(Console.ReadLine());

                double area = Operation.TriangleArea(value);
                Console.WriteLine($"Площадь треугольника равна: {area:#.##}");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Введите значения трех сторон треугольника:");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                double area = Operation.TriangleArea(a, b, c);
                Console.WriteLine($"Площадь треугольника равна: {area:#.##}");
            }
        }
    }
}

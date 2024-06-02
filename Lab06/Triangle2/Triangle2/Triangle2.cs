using System;

namespace Triangle2
{
    internal class Triangle2
    {
        double a;
        double b;
        double c;
        public Triangle2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double Perimeter()
        {
            return a + b + c;
        }
        public double Area()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        public void PrintSides()
        {
            Console.WriteLine($"Сторона А:{a:##.##}");
            Console.WriteLine($"Сторона В:{b:##.##}");
            Console.WriteLine($"Сторона С:{c:##.##}");
        }
        public bool IsTriangleExist()
        {
            return a + b > c && b + c > a && a + c > b;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Пожалуйста, введите длины сторон треугольника:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Triangle2 triangle = new Triangle2(a, b, c);
            triangle.PrintSides();

            if (triangle.IsTriangleExist())
            {
                Console.WriteLine($"Периметр треугольника: {triangle.Perimeter():##.##}");
                Console.WriteLine($"Площадь треугольника: {triangle.Area():##.##}");
            }
            else
            {
                Console.WriteLine("Треугольник не определен");
            }
        }
    }
}

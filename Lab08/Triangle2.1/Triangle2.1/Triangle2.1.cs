using System;

namespace Triangle2._1
{
    internal class Triangle2_1
    {
        double a;
        double b;
        double c;
        public Triangle2_1(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Triangle2_1(double sideLength)
        {
            a = sideLength;
            b = sideLength;
            c = sideLength;
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
            Console.WriteLine($"Сторона А: {a}");
            Console.WriteLine($"Сторона В: {b}");
            Console.WriteLine($"Сторона С: {c}");
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
            Triangle2_1 triangle = new Triangle2_1(a, b, c);
            triangle.PrintSides();

            if (triangle.IsTriangleExist())
            {
                Console.WriteLine($"Периметр треугольника: {triangle.Perimeter()}");
                Console.WriteLine($"Площадь треугольника: {triangle.Area():##.##}");
            }
            else
            {
                Console.WriteLine("Треугольник не определен");
            }
            Console.WriteLine("Введите длинну стороны равностороннего треугольника:");
            double sideLength = double.Parse(Console.ReadLine());
            Triangle2_1 equilateralTriangle = new Triangle2_1(sideLength);
            equilateralTriangle.PrintSides();

            if (equilateralTriangle.IsTriangleExist())
            {
                Console.WriteLine($"Периметр треугольника: {equilateralTriangle.Perimeter()}");
                Console.WriteLine($"Площадь треугольника: {equilateralTriangle.Area():##.##}");
            }
            else
            {
                Console.WriteLine("Равносторонний треугольник не определен");
            }
        }
    }
}

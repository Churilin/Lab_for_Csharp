using System;

namespace QuadraticEquation
{
    public class QuadraticEquation
    {
        public static int CalculateRoots(double a, double b, double c, ref double root1, ref double root2)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return 1;
            }
            else if (discriminant == 0)
            {
                root1 = root2 = -b / (2 * a);
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите коэффициенты a, b, c:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double root1 = 0, root2 = 0;
            int result = QuadraticEquation.CalculateRoots(a, b, c, ref root1, ref root2);

            switch (result)
            {
                case 1:
                    Console.WriteLine($"Корни уравнения с коэффициентами a = {a}, b = {b}, c = {c}: x1 = {root1}, x2 = {root2}");
                    break;
                case 0:
                    Console.WriteLine($"Корни уравнения с коэффициентами a = {a}, b = {b}, c = {c} равны: x1 = x2 = {root1}");
                    break;
                case -1:
                    Console.WriteLine($"Корней уравнения с коэффициентами a = {a}, b = {b}, c = {c} не существует");
                    break;
            }
        }
    }
}
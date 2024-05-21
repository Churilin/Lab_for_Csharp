using System;

namespace Divider
{
    internal class DivedIt
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Пожалуйста, введите первое число: ");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);

                Console.WriteLine("Пожалуйста, введите второе число:");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);

                int k = i / j;
                Console.WriteLine($"Результат деления {0} на {1} равно { 2 }", i, j, k);
            }
            catch (Exception e)
            {
                Console.WriteLine("Исключительная ситуация: {0}",e.Message);
            }
        }
    }
}

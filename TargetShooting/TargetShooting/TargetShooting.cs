using System;

namespace TargetShooting
{
    class TargetShooting
    {
        static void Main()
        {
            int totalScore = 0;
            int count = 0;

            while (count <= 3)
            {
                Console.WriteLine("Введите число координаты х от 1 до 30: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число координаты у от 1 до 30: ");
                int y = Convert.ToInt32(Console.ReadLine());
                int score = CalculateScore(x, y);
                totalScore += score;
                Console.WriteLine($"Набрано очков за выстрел: {score}");
                count++;
            }
            Console.WriteLine($"Сумма очков: {totalScore}");
        }

        static int CalculateScore(int x, int y)
        {
            if (x <= 10 && y <= 10)
            {
                return 10;
            }
            else if (x <= 20 && y <= 20)
            {
                return 5;
            }
            else if (x <= 30 && y <= 30)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
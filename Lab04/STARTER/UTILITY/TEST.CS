namespace Utils
{
    using System;

    public class Test
    {
        public static void Main()
        { 
            int x;
            int y;
            int greather;

            Console.WriteLine("Введите первое число: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            y = int.Parse(Console.ReadLine());

            greather = Utils.Greater(x, y);
            Console.WriteLine("Большее значение имеет " + greather);

            Console.WriteLine("Перед заменой: " + x + "," + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("После замены: " + x + "," + y);

            int f;
            bool ok;
            Console.WriteLine("Число для факториала:");
            x = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(x, out f);
            if (ok)
                Console.WriteLine("Факториал " + x + " = " + f);
            else
                Console.WriteLine("Не удалось вычислить факториал");
            }
      }
}
using System;

namespace Array
{
    class Array
    {
        static void Main()
        {
            double[] array = new double[6];

            Console.WriteLine("Введите значения элементов массива:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                array[i] = double.Parse(Console.ReadLine());
            }
            double sum = CalcSum(array);
            double average = CalcAverage(array);
            (double negSum, double positSum) = CalcPositNegSum(array);
            Console.WriteLine($"Сумма всех элементов массива: {sum:#.##}");
            Console.WriteLine($"Среднее значение: {average:#.##}");
            Console.WriteLine($"Сумма отрицательных элементов: {negSum:#.##}");
            Console.WriteLine($"Сумма положительных элементов: {positSum:#.##}");
        }
        static double CalcSum(double[] array)
        {
            double sum = 0;
            foreach (double element in array)
            {
                sum += element;
            }
            return sum;
        }
        static double CalcAverage(double[] array)
        {
            double sum = CalcSum(array);
            double average = (double)sum / array.Length;
            return average;
        }
        static (double negSum, double positSum) CalcPositNegSum(double[] array)
        {
            double negSum = 0;
            double positSum = 0;

            foreach (double element in array)
            {
                if (element < 0)
                {
                    negSum += element;
                }
                else if (element > 0)
                {
                    positSum += element;
                }
            }
            return (negSum, positSum);
        }
    }
}

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

            Console.WriteLine("������� ������ �����: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("������� ������ �����: ");
            y = int.Parse(Console.ReadLine());

            greather = Utils.Greater(x, y);
            Console.WriteLine("������� �������� ����� " + greather);

            Console.WriteLine("����� �������: " + x + "," + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("����� ������: " + x + "," + y);

            int f;
            bool ok;
            Console.WriteLine("����� ��� ����������:");
            x = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(x, out f);
            if (ok)
                Console.WriteLine("��������� " + x + " = " + f);
            else
                Console.WriteLine("�� ������� ��������� ���������");
            }
      }
}
using System;

namespace Utils
{
    internal class Test
    {
        static void Main()
        {
            string message;
            Console.WriteLine("Enter string to reverse: ");
            message = Console.ReadLine();

            Utils.Reverse(ref message);
            Console.WriteLine(message);
        }
    }
}

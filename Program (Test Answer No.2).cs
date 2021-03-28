using System;

namespace Test_Answer_No._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = a; int y = b;

            while (x != y)
            {
                while (x < y)
                {
                    x = x + a;
                }
                while (x > y)
                {
                    y = y + b;
                }
            }
            Console.WriteLine(x);
        }
    }
}

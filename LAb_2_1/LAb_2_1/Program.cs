using System;

namespace LAb_2_1
{
    namespace ConsoleApplication6

    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите a,b,c");
                double a = Convert.ToInt32(Console.ReadLine());
                double b = Convert.ToInt32(Console.ReadLine());
                double c = Convert.ToInt32(Console.ReadLine());
                double dis = (b * b - 4 * a * c);
                if (dis > 0)
                {
                    double x1 = (-b + Math.Sqrt(dis)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(dis)) / (2 * a);
                    Console.WriteLine("x1=" + x1 + "x2=" + x2);

                }
                else if (dis == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("x=" + x);
                }
                else
                {
                    double y = 0;5

                    Console.WriteLine("x + i * y");
                    Console.WriteLine("x - i * y");
                }
            }
        }
    }
}
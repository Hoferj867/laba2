using System;

namespace laba_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество сгаемых: ");
            int a = int.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("ошибка");
            }
            else
            {
                double Pi = 1;
                for (double i = 1, del = 3; i <= a; i++, del += 2)
                {
                    if (i % 2 != 0)
                    {
                        Pi -= 1 / del;
                    }
                    if (i % 2 == 0)
                    {
                        Pi += 1 / del;
                    }
                }
                Pi *= 4;
                Console.WriteLine("Pi = " + Pi);
                Console.ReadKey();
            }
        }
    }
}

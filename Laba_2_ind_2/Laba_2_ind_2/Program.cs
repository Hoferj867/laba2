using System;

namespace Laba_2_ind_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите а:");
            int a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b:");
            int b= Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (a < b)
            {
                for(int i= a;i<b;i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine(sum);
            }
           
        }
    }
}

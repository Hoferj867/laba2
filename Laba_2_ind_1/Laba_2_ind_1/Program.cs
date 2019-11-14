using System;

namespace Laba_2_ind_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (day > 9 && day < 32)
            {
                Console.Write(day + ".");
            }
            else
            {
                Console.Write("0" + day+".");
            }
            if(month>9 && month<13)
                {
                Console.Write(month + ".");
                }
            else
            {
                Console.Write("0" + month + ".");
            }
             if (year > 0 && year < 5000)
            {
                Console.Write(year);
            }
            
        }
    }
}

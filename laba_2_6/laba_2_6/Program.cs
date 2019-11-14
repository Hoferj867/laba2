using System;

namespace laba_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int N = Convert.ToInt32(Console.ReadLine());

            for(int N =1;N<99;N++)

            if (N >= 11 && N <= 14)
            {
                Console.WriteLine(N + "лет");
            }
            else {

                int val = N % 10;

            switch (val)
            {

                case 1: Console.WriteLine(N + "год"); break;
                case 2:
                case 3:
                case 4: Console.WriteLine(N + "года"); break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 0: Console.WriteLine(N + "лет"); break;


            }
        }

        }
    }
}

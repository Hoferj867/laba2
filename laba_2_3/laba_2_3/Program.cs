using System;

namespace laba_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int f0 = 1;
            int f1 = 1;
            int k = 0;
            for (int i = 0;/* i<10000*/; i++)
            {
                int fi = f0 + f1;
                f0 = f1;
                f1 = fi;
                if (f0 > 999 && f0<10000)
                {
                    k++;
                }

                if (f0 > 10000)
                    break;
            }
            Console.WriteLine(k);

            Console.ReadKey();
        }
    }
}

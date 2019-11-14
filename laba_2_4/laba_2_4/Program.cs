using System;

namespace laba_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(5));
            double x = Convert.ToDouble(Console.ReadLine());
            double q = Convert.ToDouble(Console.ReadLine());
            double cos = 1;
            bool plus = false;
            int k = 1;
            for (int i = 2; ; i += 2, plus = !plus)
            {
                double c = Math.Pow(x, i);
                double z = Fact(i);
                double sum = c / z;
                if (plus)
                {
                    cos += sum;

                }
                else
                {
                    cos -= sum;
                }
                k++;
                double y = Math.Abs(sum);
                if (y < q)
                    break;
            }
            Console.WriteLine(cos);
            Console.WriteLine(k);
        }
        static double Fact(double value)
        {
           double retValue=1;
            ///

            for( int i = 1; i < value+1; i++)
            {
                retValue *= i;
               
            }

            ///
            return retValue;
        }
    }
}

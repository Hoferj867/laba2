using System;

namespace Laba_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int N = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            for(int x =0; x<N; x++)
            {
                for(int y=0; y<N; y++)
                {
                    for(int z=0; z<N; z++)
                    {
                        if(Math.Pow(x,3)+Math.Pow(y,3)+Math.Pow(z,3)==N)
                        {
                            Console.WriteLine(x + " " + y + " " + z);
                            flag = false;
                        }
                    }
                }
            }
            if (flag)
            {

                Console.WriteLine("NO SUCH COMBINATIONS!");
            }
        }
    }
}

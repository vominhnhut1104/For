using System;
using System.Globalization;

namespace Bai6
{
    class For
    {
        public static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());


            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {i} :");

                if (n <= 0 || n> 20)
                {
                    Console.WriteLine("INVALID");
                }
                else

                {
                    double giaithua = 1;
                    double sum = 0;
                    for (int j = 2; j <= n; j++)
                    {
                        giaithua *= j;
                        //sum=sum + giaithua;
                        
                    }
                    Console.WriteLine(giaithua);


                }
            }


        }
    }
}
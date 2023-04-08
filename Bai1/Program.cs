using System;
namespace For
{
    class Loop { 
    
        public static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {i} :");

                if (n < 0)
                {
                    Console.WriteLine("NO RESULT");
                }
                else
                {
                    for ( int j = 0; j <= n; j++)
                    {
                        if ( j % 2 == 0)
                        {
                            Console.Write(j + " ");
                        }    
                    }
                    Console.WriteLine();    
                } 

            }
        }
    }
}

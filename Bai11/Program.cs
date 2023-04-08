using System;
using System.Xml.Schema;

namespace Bai10
{
    // tinh tong cac chu so nguyen duong
    class Loop
    {
        public static void Main(string[] args)
        {


            
            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.Write($"Test {i}: "); // in ra thứ tự bộ test
                if (n < 0)
                {
                    Console.WriteLine("Invalid");
                }
                else
                {
                    int tich = 1;
                    for (int m = n; m > 0; m = m / 10)
                    {

                        tich = tich * (m % 10);


                    }
                    Console.WriteLine(tich);

                }

            }
        }
    }
}


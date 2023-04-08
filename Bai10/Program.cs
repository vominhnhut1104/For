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
                if (n < 0) Console.WriteLine("Invalid");
                int m = n;
                int sum = 0;
                while (m > 0)
                {
                    
                    sum = sum + m % 10;
                    m = m / 10;

                }
                Console.WriteLine(sum);
                
            }
        }
    }
}


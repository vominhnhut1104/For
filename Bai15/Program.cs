using System;
using System.Xml.Schema;

namespace Bai13
{
    // tìm cặp số thân thiét

   /* Cặp số thân thiết.Hãy kiểm tra xem cặp số cho trước có phải cặp số thân thiết hay không.
Cặp số thân thiết là cặp số sao cho tổng các ước nhỏ hơn chính bản thân nó cộng lại bằng với số
kia. Ví dụ 220 và 284 là cặp số thân thiết vì tổng ước của 220: 1 + 2 +4 + 5 + 10 + 11 + 20 + 45 +
55 + 110 = 284. Và 1 + 2 + 4 + 71 + 142 = 220.
   */
    class Loop
    {
        public static void Main(string[] args)
        {



            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                var data = Console.ReadLine().Split(' ');
                int n = int.Parse(data[0]);
                int k = int.Parse(data[1]);
                Console.WriteLine($"Test {i}: "); // in ra thứ tự bộ test
               
                int count = 0;
                
                for (int j = 1; j < n; j++)
                {
                    if (n % j == 0)
                    {
                        count = count + j;
                    
                    }

                }
                int dem = 0;
                for (int g = 1; g <k; g++)
                {
                    if (k % g == 0)
                    {
                        dem= dem + g;

                    }

                }
                if ( count == k && dem == n)
                {
                    Console.WriteLine("YES");

                }
                else
                Console.WriteLine("NO");


            }
        }
    }
}



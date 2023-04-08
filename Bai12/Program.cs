using System;
using System.Xml.Schema;

namespace Bai10
{
    // tinh tong cac chu so nguyen duong
    class Loop
    {
        public static void Main(string[] args)
        {

            //Công thức truy hồi của dãy fibonacci có dạng: số phía sau = 2 số phía trc cộng lại, dãy này băt đầu là 2

            int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Test {i}: "); // in ra thứ tự bộ test
                if (n < 0)
                {
                    Console.WriteLine("Invalid");
                }
                else
                {
                    decimal f0 = 0;
                    decimal f1 = 1;
                    decimal fn = n;
                    for (int j = 2; j <= n; j++)
                    {
                        fn = f0 + f1;
                        f0 = f1;
                        f1 = fn;

                        Console.Write(fn+" "); int ra dãy fibonacy
                        
                    }
                    Console.WriteLine("so bonacy thu n :",fn);

                }
                

            }
        }
        
    }
}


using System;
using System.Globalization;

namespace Bai4
{
    class For
    {
        public static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());


            for (int i = 1; i <= t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Test {i} :");

                if (n <= 0)
                {
                    Console.WriteLine("INVALID");
                }
                else

                {
                    double sum = 0; // đặt sum = 0 ở đây mà ko đặt ở trên là để kết quả ko bị cộng tiếp sum của test trc 
                    for (int j = 1; j <= n; j++)
                    {
                        sum = sum + (1.0 / j);

                    }
                    Console.WriteLine(Math.Round(sum,3));// math.Round sẽ lấy số thập phân mà ko lấy số 0


                }
            }

            //int t = int.Parse(Console.ReadLine()); // đọc vào số bộ test
            //for (int i = 1; i <= t; i++)
            //{
            //    int n = int.Parse(Console.ReadLine()); // đọc vào số n
            //    Console.WriteLine($"Test {i}:"); // in ra thứ tự bộ test
            //    if (n <= 0)
            //    {
            //        Console.WriteLine("INVALID");
            //    }
            //    else
            //    {
            //        double sum = 0;
            //        for (int j = 1; j <= n; j++) // xét j từ 1 đến n
            //        {
            //            sum += 1.0 / j; // cộng 1/j vào tổng
            //        }
            //        // in kết quả hiển thị 3 chữ số sau dấu phẩy
            //        Console.WriteLine($"{sum:f3}");
            //    }

            //}
        }
    }
}


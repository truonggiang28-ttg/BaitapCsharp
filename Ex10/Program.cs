using System;
using System.Collections.Generic;

namespace BaiTap
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Thai Truong Giang_2415053122313");
            Console.WriteLine("-------------------------------\n");

            List<int> list = new List<int>();
            Console.Write("Nhap so phan tu: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Phan tu thu {i + 1} la: ");
                int num = Convert.ToInt32(Console.ReadLine());
                list.Add(num);
            }
            Console.Write("\nDay da nhap vao la: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            int min = list[1];
            foreach(int j in list)
            {
                if (j < min)
                    min = j;
            }
            Console.WriteLine($"\nSo nho nhat tim duoc la: {min}");
        }
    }
}
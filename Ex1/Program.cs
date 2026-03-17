using System;
using System.Collections.Generic;
using System.Collections;
namespace BaiTap
{
    public class ex1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Thai Truong Giang_2415053122313");
            Console.WriteLine("---------------------------------\n");
            List<int> list = new List<int>();
            Console.Write("Nhap so phan tu: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++ ) 
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                int num = Convert.ToInt32(Console.ReadLine());
                list.Add(num);
            }
            Console.Write("\nDay da nhap la: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
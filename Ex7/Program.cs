using System;
using System.Collections.Generic;
using System.Collections;
namespace BaiTap
{
    public class Ex7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Thai Truong Giang_2415053122313");
            Console.WriteLine("-------------------------------\n");
            List<int> list = new List<int>();
            Console.WriteLine("Nhap so phan tu: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine($"Nhap phan tu thu {i+1}:  ");
                int num = Convert.ToInt32(Console.ReadLine());
                list.Add(num);
            }
            list.Sort();
            Console.Write("\nDay sau sap xep tang dan la: ");
            for(int so = 0; so < list.Count; so++)
            {
                Console.Write($"{list[so]}" + " ");
            }
            Console.ReadKey();
        }
    }
}
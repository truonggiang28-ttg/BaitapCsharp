using System;
using System.Collections.Generic;

namespace BaiTap
{
    public class Ex9
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
                Console.Write($"Nhap phan tu thu {i + 1}:  ");
                int num = Convert.ToInt32(Console.ReadLine());
                list.Add(num);
            }
            Console.Write("\nDay da nhap vao la: ");
            foreach (int i in list)
            {
                Console.Write(i + " "); 
            }
            for (int m = 0; m < list.Count; m++)
            {
                for (int p = m + 1; p < list.Count; p++)
                {
                    if (list[p] == list[m])
                    {
                        list.RemoveAt(p);
                        p--; 
                    }
                }
            }

            Console.WriteLine("\nKet qua sau khi xoa trung lap: ");
            foreach (int j in list)
            {
                Console.Write(j + " ");
            }

            Console.ReadKey();
        }
    }
}
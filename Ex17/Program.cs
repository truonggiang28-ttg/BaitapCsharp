using System;
using System.Collections.Generic;

namespace BaiTap
{
    public class Ex17
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

            
            int demmax = 0;
            int xuathienmax = list[0];
            for(int i = 0; i < list.Count; i++)
            {
                int dem = 1;
                for (int j = i + 1; j < list.Count; j++)
                {
                    
                    if (list[i] == list[j])
                        dem++;
                }
                if(dem > demmax)
                {
                    demmax = dem;
                    xuathienmax = list[i];
                }
            }
            Console.WriteLine($"Phan tu xuat hien nhieu nhat la so {xuathienmax}, {demmax} lan xuat hien");
        }
    }
}
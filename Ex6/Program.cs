using System;
using System.Collections.Generic;

namespace BaiTap
{
    public class Ex6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Thai Truong Giang_2415053122313");
            Console.WriteLine("-------------------------------\n");

            List<string> list = new List<string>();
            list.Add("Thai Truong Giang");
            list.Add("Thai Phuong Nam");
            list.Add("Nguyen Thai Bao");
            list.Add("Nguyen Viet Anh");

            Console.WriteLine("----------------------\n");
            Console.WriteLine("Danh sach ten: ");
            foreach (string ten in list)
            {
                Console.WriteLine(ten);
            }
            Console.Write("\nNhap ten ban muon tim: ");
            String Tenfind = Console.ReadLine().ToLower();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower() == Tenfind)
                {
                    Console.WriteLine("Ten co trong mang");
                    break;
                }
                else if (i == list.Count - 1)
                {
                    Console.WriteLine("khong co");
                }
            }

            Console.ReadKey();
        }
    }
}
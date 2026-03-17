using System;
using System.Collections.Generic;
using System.Collections;
namespace BaiTap
{
    public class Ex5
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
            Console.WriteLine("Mang truoc khi xoa la: ");
            foreach (string n in list) 
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("----------------------\n");
            Console.Write("Nhap ten ban muon xoa: ");
            String Tenremove = Console.ReadLine().ToLower();
            for (int i = 0; i<list.Count; i++)
            {
                if (list[i].ToLower() == Tenremove)
                {
                    list.RemoveAt(i);
                }
            }

            Console.WriteLine("----------------------\n");
            Console.WriteLine("Mang sau khi xoa la: ");
            foreach(string s in list)
            {
                Console.WriteLine(s); 
            }
            Console.ReadKey();
        } 
    } 
}
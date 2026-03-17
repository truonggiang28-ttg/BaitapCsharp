using System;
using System.Collections.Generic;
using System.Collections;
namespace BaiTap
{
    public class ex2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Thai Truong Giang_2415053122313");
            Console.WriteLine("---------------------------------\n");
            List<int> list = new List<int>();
            list.AddRange(new int[] { 5, 7, 9, 11, 13 });
            int S = 0;
            Console.WriteLine("Cac phan tu trong list la:");
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
            for (int i = 0; i < list.Count; i++)
            {
                S += list[i];
            }
            Console.WriteLine($"\nTong cua cac phan tu nhap vao la = {S}");
            Console.ReadKey();
        }
    }
}
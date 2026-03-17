using System;
using System.Collections.Generic;
using System.Collections;
namespace BaiTap
{
    public class ex3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Thai Truong Giang_2415053122313");
            Console.WriteLine("---------------------------------\n");
            List<int> list = new List<int>();
            list.AddRange(new int[] { 5, 7, 15, 11, 13 });
            Console.WriteLine("Cac phan tu trong day la:");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            int Max = list[1];
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] > Max)
                    Max = list[i];
            }
            Console.WriteLine($"\nPhan tu lon nhat trong day la = {Max}");
            Console.ReadKey();

        }
    }
}
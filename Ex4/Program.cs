using System;
using System.Collections.Generic;
using System.Collections;
namespace BaiTap
{
    public class ex4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Thai Truong Giang_2415053122313");
            Console.WriteLine("---------------------------------\n");
            List<int> list = new List<int>();
            list.AddRange(new int[] { 5, 6, 9, 16, 13, 0 });
            Console.WriteLine("Cac phan tu trong day la:");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            int Count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                    Count++;
            }
            Console.WriteLine($"\nSo phan tu so chan trong day la: {Count}");
            Console.ReadKey();
        }
    }
}
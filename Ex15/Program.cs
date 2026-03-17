using System;
using System.Collections.Generic;
using System.Transactions;

namespace BaiTap
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Thai Truong Giang_2415053122313");
            Console.WriteLine("-------------------------------\n");
            Dictionary<string, string> trans = new Dictionary<string, string>()
            {
                {"hi", "chao" },
                {"system","he thong" },
                {"apple","qua tao" }
            };
            Console.WriteLine("Nhap tu can tra: ");
            String Tutienganh = Console.ReadLine().ToLower();
            if (trans.ContainsKey(Tutienganh)) 
            {
                Console.WriteLine($"\nNghia cua tu {Tutienganh} la {trans[Tutienganh]}");
            }
            else
            {
                Console.WriteLine($"\nTu {Tutienganh} khong co trong tu dien");
            }

        }
    }
}
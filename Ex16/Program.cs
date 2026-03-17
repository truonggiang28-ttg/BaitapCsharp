using System;
using System.Collections.Generic;

namespace BaiTap
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Thai Truong Giang_2415053122313");
            Console.WriteLine("-------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            string input = Console.ReadLine();

            Dictionary<char, int> countDict = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (countDict.ContainsKey(c))
                {
                    countDict[c]++;
                }
                else
                {
                    countDict.Add(c, 1);
                }
            }

            Console.WriteLine("Ket qua:");
            foreach (var item in countDict)
            {
                Console.Write($"{item.Key} : {item.Value}   ");
            }

            Console.ReadKey();
        }
    }
}
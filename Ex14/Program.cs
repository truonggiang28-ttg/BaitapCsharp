using System;
using System.Collections.Generic;
using System.Collections;
namespace BaiTap
{
    public class Ex13
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Thai Truong Giang_2415053122313");
            Console.WriteLine("-------------------------------\n");
            List<Student> list = new List<Student>();
            list.Add(new Student { Id = 1, Name = "Giang" });
            list.Add(new Student { Id = 2, Name = "Nam" });
            list.Add(new Student { Id = 3, Name = "Bao" });

            foreach (Student i in list)
            {
                Console.WriteLine($"Id: {i.Id} | Ho ten: {i.Name}");
            }

            Console.Write("\nNhap Id sinh vien muon xoa: ");
            int IdRemove = Convert.ToInt32(Console.ReadLine());
            for(int j= 0; j<list.Count; j++)
            {
                if (list[j].Id == IdRemove)
                    list.Remove(list[j]);
            }
            Console.WriteLine("\nDanh sach sinh vien sau khi xoa");
            foreach (Student k in list)
            {
                Console.WriteLine($"Id: {k.Id} | Ho ten: {k.Name}");
            }
        }
    }
}
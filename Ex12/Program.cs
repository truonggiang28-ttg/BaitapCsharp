using System;
using System.Collections.Generic;
using System.Collections;
namespace BaiTap
{
    public class Ex12
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

            Console.Write("\nNhap ten sinh vien muon tim: ");
            String NameFind = Console.ReadLine();
            foreach(Student j in list)
            {
                if (j.Name.ToLower() == NameFind.ToLower())
                {
                    Console.WriteLine($"Sinh vien muon tim la: Id = {j.Id} Ho ten ={j.Name}"); 
                }
            }
        }
    }
}
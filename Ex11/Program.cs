using System;
using System.Collections.Generic;
using System.Collections;
namespace BaiTap
{
    public class Ex11
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
            list.Add(new Student {Id = 1, Name = "Thai Truong Giang" });
            list.Add(new Student {Id = 2, Name = "Thai Phuong Nam" });
            list.Add(new Student {Id = 3, Name = "Nguyen Thai Bao" });

            foreach (Student i in list) 
            {
                Console.WriteLine($"Id: {i.Id} | Ho ten: {i.Name}");
            }
        } 
    }
}
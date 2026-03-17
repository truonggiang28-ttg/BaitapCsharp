using System;
using System.Collections.Generic;

namespace BaiTap
{
    public class Ex18
    {
        public class Student
        {
            public string Name { get; set; }
            public double Score { get; set; }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Thai Truong Giang_2415053122313");
            Console.WriteLine("-------------------------------\n");
            List<Student> student = new List<Student>();
            student.Add(new Student { Name = "Giang", Score = 9.2 });
            student.Add(new Student { Name = "Nam", Score = 9.9 });
            student.Add(new Student { Name = "Han", Score = 9.92 });
            student.Add(new Student { Name = "Bao", Score = 8.7 });
            student.Add(new Student { Name = "Phuong", Score = 8.54 });

            Console.WriteLine("Danh sach sinh vien va diem: ");
            foreach(var item in student)
            {
                Console.WriteLine($"{item.Name} | {item.Score}");
            }

            String tenSv = " ";
            double diemMax = student[0].Score;
            for (int i = 0; i < student.Count; i++) 
            {
                if(student[i].Score > diemMax)
                {
                    diemMax = student[i].Score;
                    tenSv = student[i].Name;
                }
            }
            Console.WriteLine($"\nSinh vien co diem cao nhat la {tenSv} | {diemMax}");
        }
    }
}
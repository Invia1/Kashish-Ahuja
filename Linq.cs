
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExample
{
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
       
    }

    class Program
    {
        static void Main()
        {

            List<Student> employees = new List<Student>()
            {
                new Student() { RollNo = 1, Name = "Deepa"},
                new Student() { RollNo = 2, Name = "Deepak" },
                new Student() { RollNo = 3, Name = "Kashish",  },
                new Student() { RollNo = 4, Name = "Tanu" },
                new Student() { RollNo = 5, Name = "Ankita" }
            };


            // Where using to filter the data 

            IEnumerable<Student> result = employees.Where(emp => emp.RollNo == 1);

            foreach (Student item in result)
            {
                Console.WriteLine(item.RollNo + ", " + item.Name);
            }

            Console.ReadKey();
        }
    }
}
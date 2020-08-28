using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stdlist = new List<Student>() {
            new Student(){StudentName="Hitesh",StudentBatchYear=2020,StudentId=101,DeptId=200 },
            new Student(){StudentName="Akshay",StudentBatchYear=2019,StudentId=103,DeptId=203 },
            new Student(){StudentName="Satish",StudentBatchYear=2020,StudentId=106,DeptId=206 },
            new Student(){StudentName="Rakesh",StudentBatchYear=2027,StudentId=107,DeptId=200 },
            };

            List<Department> deptlist = new List<Department>()
            {
            new Department(){DeptId=200,DepartmentName="Mechanical",Hod="Dubey"},
            new Department(){DeptId=203,DepartmentName="Extc",Hod="Manisha"},
            new Department(){DeptId=200,DepartmentName="Mechanical",Hod="Dubey"},
            };

            var stud = from obj in stdlist
                       where obj.StudentBatchYear > 2022
                       select obj;

            stud.ToList().ForEach(s => Console.WriteLine(s.StudentName));

           

            var res1 = from stu in stdlist
                       join
                       dept in deptlist
                       on stu.DeptId equals dept.DeptId
                       select new
                       {
                           stu.StudentId,
                           stu.StudentName,
                           stu.StudentBatchYear,
                           dept.DepartmentName
                        };
           
        }
    }

    class Student
    {
        public string StudentName { get; set; }
        public int StudentBatchYear { get; set; }
        public int StudentId { get; set; }
        public int DeptId { get; set; }

    }
    class Department
    {
        public int DeptId { get; set; }
        public string DepartmentName { get; set; }
        public string Hod { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empolyee> elist3 = new List<Empolyee>()
            {
                new Empolyee(){EmpId=1,EmpName="Hitesh",EmpDept=10},
                new Empolyee(){EmpId=6,EmpName="Ashok",EmpDept=80},
                new Empolyee(){EmpId=8,EmpName="Vinod",EmpDept=20},
                new Empolyee(){EmpId=10,EmpName="Harshal",EmpDept=10}
            };

            List<Dept> deplist = new List<Dept>()
            {
                new Dept(){DeptId=10,DeptName="HR"},
                new Dept(){DeptId=20,DeptName="IT"},
                new Dept(){DeptId=10,DeptName="HR"},
                new Dept(){DeptId=20,DeptName="IT"},
                new Dept(){DeptId=30,DeptName="Network"}
            };

            var Hitesh = from obj in elist3
                         from obj1 in deplist
                         select obj;

            var Hitesh2 = from e in elist3
                          from d in deplist
                          where e.EmpDept == d.DeptId
                          select e;

            var Hitesh3 = from d in deplist
                          from e in elist3
                          where d.DeptId ==e.EmpDept
                          select d;

            var Hitesh4 = from e in elist3
                          join d in deplist
                          on e.EmpDept equals d.DeptId into empdept
                          from ed in empdept.DefaultIfEmpty()
                          select ed;

            var Hitesh5 = from d in deplist
                          join e in elist3
                          on d.DeptId equals e.EmpDept into empdept
                          from de in empdept.DefaultIfEmpty()
                          select de;

            var linqRes = (from c in deplist
                           select c).Skip(2).Take(2);

            int[] numbers = { 2, 5, 10 };
             var result = numbers.Sum();

            Console.WriteLine("Summing the numbers yields:");
            Console.WriteLine(result);

            Console.ReadLine();
            
        }
    }
    class Empolyee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpDept { get; set; }
    }
    class Dept
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seconddotnetprogram
{
    public class Employee
    {
        public int empid;
        public string empname;
        public string departmentname;
    }
    public class Department
    {
        public int deptid;
        public string deptname;
    }

    public class EmpDept
    {
        public Employee emp;
        public Department dept;
    }
}

//#define Uat
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerManipulation
{
    unsafe class Program
    {
        #region LocalVariable


        #endregion

        #region MainProgram

        static void Main(string[] args)
        {
#if Dev
            Console.WriteLine("You are in Dev Region");
#elif Uat
         Console.WriteLine("You are in Uat Region");
#else
            Console.WriteLine("You are in Prod Region");
#endif



            int x = 100;

            /* The &x gives the memory address of the variable x,
             * which we can assign to a pointer variable */

            int* ptr = &x;
            Console.WriteLine((int)ptr); // Displays the memory address
            Console.WriteLine(*ptr); // Displays the value at the memory 
            Add(50, 80);
            Employee obj = new Employee();
            obj = AddEmployee(100, "dac", "cse");
            Console.WriteLine(obj.empid);
            Console.WriteLine(obj.empname);
            Console.WriteLine(obj.departmentname);
            double s, c, sr;
            int y = 9;

            GetMatFunctions(y, out s, out  c, out sr);

            Console.WriteLine(AddEmployee1(200, "da'selva", "it"));
            Console.ReadLine();

            //unsafe
            //{

            //}

        }

        #endregion

        #region PublicMethods


        public static void Add(int x, int y)
        {
            int result = x + y;
            Console.WriteLine("The result of add is " + result);
        }

        public static Employee AddEmployee(int eid, string ename, string deptname)
        {
            string newname = eid + "'" + ename + "'" + deptname;

            Employee e1 = new Employee();
            e1.empid = eid;
            e1.empname = ename;
            e1.departmentname = deptname;
            return e1;
        }

        public static string AddEmployee1(int eid, string ename, string deptname)
        {
            string newname = eid + "'" + ename + "'" + deptname;
            return newname;
        }

        public static void GetMatFunctions(int x, out double square, out double cube, out double sqareroot)
        {
            square = Math.Pow(x, 2);
            cube = Math.Pow(x, 3);
            sqareroot = Math.Sqrt(x);
        }

        #endregion
    }

    #region UserDefinedClasses

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
    #endregion
}

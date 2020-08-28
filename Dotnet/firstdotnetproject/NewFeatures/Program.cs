using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vv = new Vehicle();
            vv.ManufactureYear = 2005;
            //Console.WriteLine(vv.ManufactureYear);
            car cc = new car();
            cc.Start();
            cc.Break();

            Age aaa = new Age();
            aaa.dosoemthing();
            Age.firststaticclass();

            Age bbb = new Age(2025);
            bbb.dosoemthing();
            Age.firststaticclass();
            Age ccc;
            //readonly
            Hashtable xxx = new Hashtable();
            xxx.Add(10, "asasa");
            xxx.Add("aadsasda", "ewrwerew");
            xxx.Add("adasda", 50);

            Dictionary<int, string> dt = new Dictionary<int, string>();
            //const

            int xx = 1324131;


            //3.0
            var zz = 345;

            //c4.0
            dynamic ty;
            ty = 67;
            Console.WriteLine(ty);

            ty = "asasdasdasd";
            Console.WriteLine(ty);

            //Anoynomous Types
            var e1 = new { EmpId = 101, Ename = "Vikram" };
            var e2 = new { EmpId = 102, Ename = "Tejas" };
            var e3 = new { EmpId = 103, Ename = "Monica" };
            var e4 = new { EmpId = 104, Ename = "Prabhat" };

            Console.WriteLine("Emp NO {0} and EName {1} ", e1.EmpId, e1.Ename);
            Console.WriteLine("Emp NO {0} and EName {1} ", e2.EmpId, e2.Ename);
            Console.WriteLine("Emp NO {0} and EName {1} ", e3.EmpId, e3.Ename);
            Console.WriteLine("Emp NO {0} and EName {1} ", e4.EmpId, e4.Ename);

            Employee e13 = new Employee();
            e13.EmpId = 100;
            e13.EmpName = "cdac";

            Employee e14 = new Employee();
            e14.EmpId = 1000;
            e14.EmpName = "dac";

            List<Employee> elist = new List<Employee>();
            elist.Add(e13);
            elist.Add(e14);

            //Collection Initializer
            List<int> rr = new List<int>() { 12, 52, 85, 96, 78, 45, 36, 56, 96 };
            List<string> srt = new List<string>() { "Chennai", "Hyd", "Bangalore","Agra","Pune","Vizak","Delhi","Bhopal","Patna","gurugram"};
            string resnewcollection = string.Join(",", srt);
            var res = resnewcollection.Split(',');
            foreach(var amit in srt)
            {
                Console.WriteLine(amit);
            }
            string searchterm = "BanffGalore";
            //Liner Search
            var resultofbinarysearch2 = srt.FindIndex(modi => modi.ToLower() == searchterm.ToLower()); // Lambda Expression
            
            //Binary Search
            //srt.Sort();
            var resultofbinarysearch = srt.BinarySearch("Bangalore");

            //LINQ
            var res1 = (from obj in srt
                       where obj.ToLower().Contains("a")
                       orderby obj
                       select obj).Skip(2).Take(3);
            var res22 = from obj in srt
                        where obj.ToLower().Contains("a")
                        orderby obj
                        select obj;



            //Object Initializer
            Employee e15 = new Employee() { EmpId = 855, EmpName = "asdasd" };

            //Collection + Object Initializer
            List<Employee> elist3 = new List<Employee>() {
            new Employee(){EmpId=456,EmpName="modi",EmpDept=10 },
            new Employee(){EmpId=345,EmpName="shah",EmpDept=80 },
            new Employee(){EmpId=4545,EmpName="fsdf",EmpDept=20}
            };

            Employee emp111 = new Employee();
            Employee emp112 = new Employee();
            if(emp112 ==  emp111)
            {

            }

            if(emp111.Equals(emp112))
            {

            }
            List<Dept> deptlist = new List<Dept>() { 
            new Dept(){DeptID=10,DeptName="PMO"},
            new Dept(){DeptID=20,DeptName="Finance"},
            new Dept(){DeptID=30,DeptName="HRD"},
            new Dept(){DeptID=40,DeptName="External"},
            new Dept(){DeptID=50,DeptName="Boss"},
            };

            var linqResult4 = (from c in deptlist
                               select c).Skip(2).Take(2);

            //Linq to Collection  + Employee
            var linqResult1 = from obj in elist3
                              where obj.EmpName.Contains('a')
                              orderby obj.EmpId descending
                              select obj;


            //Join of Employee and Dept tables  inner join
            //inner join 1 select * from t1,t2 where t1.x = t2.x
            //inner join2 select * from t1  inner join t2 on t1.x = t2.x

            var linqResult2 = from emp in elist3
                              from dept in deptlist
                              where emp.EmpDept == dept.DeptID
                              orderby emp.EmpId descending
                              select new
                              {
                                  emp.EmpId,
                                  emp.EmpName,
                                  dept.DeptName
                              };


            var linqResult3 = from emp in elist3
                              join dept in deptlist
                              on emp.EmpDept equals dept.DeptID
                              select new
                              {
                                  emp.EmpId,
                                  emp.EmpName,
                                  dept.DeptName
                              };

            var ress = elist3.Find(y => y.EmpName == "nvb");
            string result = CommonReusableCode.CDACStringReverse("india");
            Console.WriteLine(result);

            Console.WriteLine(result.CDACStringReverse());

            string ttttt = "australia";
            Console.WriteLine(ttttt.CDACStringReverse());

            try
            {
                string fgdgdgdfg = "australia";
            }
            
            catch (DivideByZeroException eeeeee)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

            int number = 125;
            Console.WriteLine(number.SquareRoot());
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpDept { get; set; }
        //public int MobileNo { get; set; }
        //public string EmailID { get; set; }
    }

    public class Dept
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
    }

    public static class CommonReusableCode
    {
        public static string CDACStringReverse(this string input)
        {
            string result = "";
            //Method 1
            result = string.Join("", input.ToCharArray().Reverse());


            //Method2
            String res2 = new String(input.ToCharArray().Reverse().ToArray());


            //C# 1.0  char[] int[]
            //C#2.0  List<int>  List<string>
            //input.ToCharArray().Reverse().ToArray()
            //abc   [a][b][c]     [c][b][a] 

            return result;
        }

        public static double SquareRoot(this int x)
        {
            return Math.Sqrt(x);
        }

    }

    public class Age
    {
        #region LocalVariables
        public readonly int year = 2019;
        public const double pi = 3.14159265358979;
        List<int> templist = new List<int>();
        #endregion

        #region Constructor
        public Age()
        {
        }

        public Age(int year)
        {
            this.year = year;

        }
        #endregion

        #region UserDefinedMethods
        void ChangeYear()
        {
            // year = 1967; // Compile error if uncommented.
        }

        public void dosoemthing()
        {
            templist.Add(50);
            Console.WriteLine("The Year is");
            Console.WriteLine(year);

            //pi = 25;
            //year = 2020;
        }
        
        public static void firststaticclass()
        {
            Console.WriteLine("Invoked the first static class");
        }
        #endregion
    }


   

    public interface IVehicle
    {
         void Break();
         void Start();
    }

    public abstract class AVehicle
    {
        public abstract void Break();
        public void Start()
        {
            Console.WriteLine("Start of AVehicle is invoked");
        }
    }

    public class car :AVehicle
    {

        public override void Break()
        {
            Console.WriteLine("Break of Car is invoked");
        }
    }


    public sealed class Bike
    {

    }

    public class Vehicle 
    {
        private int yearofmanufacture;

        public int ManufactureYear
        {
            //get { return yearofmanufacture; }
            set { yearofmanufacture = value; }
        }

        public string Make { get; set; }
        public string Model { get; set; }
        

        public void Break()
        {
            Console.WriteLine("Break of Vehicle is invoked");
        }
        public void Start()
        {
            Console.WriteLine("Start of Vehicle is invoked");
        }
    }
}

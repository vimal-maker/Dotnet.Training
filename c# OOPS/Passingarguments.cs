using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingArgumentDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Employee emp1 = new Employee(1, "Mohan",4,"Developing");
            Employee emp2 = new Employee(2, "Raj", 3, "Maintenance");

            emp1.ShowData();
            emp2.ShowData();
        }
    }
    public class Employee
    {
        int empid;
        string empname;
        short deptid;
        string deptname;

        public Employee()
        { }
        public Employee(int eid, string ename)
        {
            empid = eid;
            empname = ename;
        }
        public Employee(int eid, string ename, short did, string dname)
        {
            empid = eid;
            empname = ename;
            deptid = did;
            deptname = dname;
        }
        public void ShowData()
        {
            Console.WriteLine("ProductId={0}",empid);
            Console.WriteLine("Productname={0}",empname);
            Console.WriteLine("DeptId={0}", deptid);
            Console.WriteLine("Deptname={0}", deptname);
            Console.ReadKey();
        }
    
    }

}       
        
    


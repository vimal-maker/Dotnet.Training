using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)   //Entry point of C#
        {
            Employee emp = new Employee();
            var salary = emp.GetSalary(30, 800);
            Console.WriteLine("Salary Without incentives: Rs {0}", salary);

            salary = emp.GetSalary(30, 800, 5000);
            Console.WriteLine("Salary With incentives: Rs {0}", salary);

            Manager om = new Manager();
            var ts = om.GetPerks(30000, 5000);
            Console.WriteLine("Salary of Manager is {0}", ts);


            College c = new College();
            var tf = c.Fees(85000, 12000);
            Console.WriteLine("Total fees for dayscoler = {0}", tf);

            tf = c.Fees(85000, 12000, 70000);
            Console.WriteLine("Total Fees for Hostellee = {0}", tf);

            HOD hsal = new HOD();
            var hdsal = hsal.prfsalary(25000);
            Console.WriteLine("The salary of HOD = {0}", hdsal);
            Console.ReadKey();
        }
    }

    public class Employee
    {
        public double GetSalary(int ndays, float spd)     //This method can be overloaded with different Signature
        {
            double salary = ndays * spd;
            return salary;
        }
    
        public double GetSalary(int ndays, float spd, float incent)    //Get salary method is overloaded
        {
            double salary = (ndays * spd) + incent;
            return salary;
        }

        //this method will be overridden in some other derived class
        public virtual double GetPerks(float salary, float pearks)
        {
            double ts = salary + pearks;
            return ts;
        }
    }

    public class Manager : Employee
    {
        public override double GetPerks(float salary, float pearks)  //signature remains same while overriding
        {
            return base.GetPerks(salary, pearks) * 1.10;
        }
    }

    public class College
    {
        public double Fees(double clgfee, double Exmfee)
        {
            double tlfee = clgfee + Exmfee;
            return tlfee;
        }

        public double Fees(double clgfee, double Exmfee, double htlfee)
        {
            double tlfee = clgfee + Exmfee + htlfee;
            return tlfee;
        }

        public virtual double prfsalary(double salary)
        {
            return salary;
        }
    }

    public class HOD : College
    {
        public override double prfsalary(double salary)
        {
            return base.prfsalary(salary) + 10000;
            
        }
    }
}
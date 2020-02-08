using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        public delegate double Saldelegate(int ds, float sd);
        static void Main(string[] args)
        {
            Saldelegate deleg = new Saldelegate(GetSalary);

            var salary = deleg.Invoke(30, 2000);
            Console.WriteLine("")
        }

    }
}

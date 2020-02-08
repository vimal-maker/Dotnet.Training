using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace generic
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList(100);
            items.Add("Hello World");
            items.Add(10);
            items.Add(DateTime.Now);
            items.Add(true);

            foreach (object obj in items)
                Console.WriteLine(obj.ToString());

            List<int> myInts = new List<int>();

            myInts.Add(10);
            myInts.Add(80);

            myInts.Add(90);
            foreach (var n in myInts)
                Console.WriteLine(n.ToString());
            Console.ReadKey();
        }
        public class Employee
            
        {
            public void ShowData(List<int>Employee)
               
        }
    }
}

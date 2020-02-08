using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqtoObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] students = new int[5] {55, 53, 97, 64, 76 };

            var knownstd = from std in students
                           orderby std descending
                             select std;

            foreach (int std in knownstd)
            {
                Console.WriteLine("Std number greater than 70: {0}", std);
            }
            Console.ReadKey();

            //using Lamda
            {
                var les = students.Where(std => std<=70);


                    foreach(int std in les)
                    { 
                    Console.WriteLine("std number lesser than 70:{0}", les);    
                    }
            }

        }
    }
}

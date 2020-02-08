using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace MultiThreadedApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s1 = new Stopwatch();

            s1.Start();
            Thread t1 = new Thread(IncrementCount2);
            IncrementCount2();
            s1.Stop();
        }

        public static void IncrementCount1()
        {
            long Count1 = 0;
            for (int i = 0; i < 5000; i++)
            {
                Count1++;
            }
            Console.WriteLine("Count1:{0}", Count1);
        }
        public static void IncrementCount2()
        {
            long Count2 = 0;
            for (int i = 0; i < 2000; i++)
            {
                Count2++;
            }
            Console.WriteLine("Count2:{0}", Count2);
        }
    }
}

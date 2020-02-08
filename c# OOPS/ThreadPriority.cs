using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPriority
{
    class Program
    {
        public static long Count1, Count2; 
        static void Main(string[] args)
        {
            Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IncrementCount2);

            t1.Start();
            t2.Start();

            t1.Priority = System.Threading.ThreadPriority.Lowest;
            t2.Priority = System.Threading.ThreadPriority.Highest;

            Thread.Sleep(1000);


            t1.Abort();
            t2.Abort();


            t1.Join();
            t2.Join();

            Console.WriteLine("Idhu verum aarambam than");
            Console.WriteLine("count1:{0}", Count1);
            Console.WriteLine("count2:{0}", Count2);
            Console.WriteLine("idhu mudivu ila da..sethu po");
            Console.ReadLine();
        }
        public static void IncrementCount1()
        {
            while(true)
            {
                Count1 += 1;
            }
        }
        public static void IncrementCount2()
        {
            while(true)
            {
                Count2 += 1;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadLocking
{
    class ThreadLock
    {
        static void Main(string[] args)
        {
            ThreadLock objTl = new ThreadLock();
            Thread T1 = new Thread(objTl.Display);
            lock (T1);
            Thread T2 = new Thread(objTl.Display);
            Thread T3 = new Thread(objTl.Display);

            T1.Start(); T2.Start(); T3.Start();
            Console.ReadLine();
        }
        public void Display()
        {
            
            
                Console.Write("[CSharp is a");
                Thread.Sleep(5000);
                Console.WriteLine("Thalavali]");
            
        }
    }
}

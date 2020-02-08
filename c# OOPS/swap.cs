using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 50;b = 30;

            Console.WriteLine("Before swap: a={0},b={1}", a,b);
            swap<int>(ref a, ref b);
            Console.WriteLine("After swap:a={0},b={1}", a, b);
            string s1, s2;


        }
    }
}

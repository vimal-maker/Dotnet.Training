using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bank_component;

namespace savingsclient
{
    class Program
    {
        static void Main(string[] args)
        {
            Savingsbank sb = new Savingsbank();
            var si = sb.simpleinterest(5000.00, 2, 5);
            Console.WriteLine("simpleinterst:{0}", si);

            var bal = sb.getbalance(8000.00, si);
            Console.WriteLine("balance:{0}", bal);
            Console.ReadKey();
        }
    }
}

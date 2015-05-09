using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq vavedete parvoto chislo:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Molq vavedete vtoroto chislo:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Sumata na chislata "+a+" i "+b+" e: "+(a+b));
        }
    }
}

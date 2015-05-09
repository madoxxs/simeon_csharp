using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealnoChislo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq vavedete realno chislo:");
            double a = double.Parse(Console.ReadLine());
            int b = 7;
            Console.WriteLine("Reziltatat ot delenieto na "+a+" s "+b+" e : "+(a/b));
        }
    }
}

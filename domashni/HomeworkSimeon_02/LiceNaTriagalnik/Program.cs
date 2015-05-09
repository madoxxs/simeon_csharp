using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiceNaTriagalnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq vavedete stranata na triagalnika:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Molq vavedete visochinata kam tazi strana:");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Liceto na triagalnika e: S = "+((a*h)/2));
        }
    }
}

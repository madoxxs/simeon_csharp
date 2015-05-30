using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("molq vavedete duma!");
            string duma = Console.ReadLine();
            Console.WriteLine("Molq vavedete izrechenie!");
            string line = Console.ReadLine();
            string line1 = line.Replace(duma, duma.ToUpper());
            Console.WriteLine(line1);
            
            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsTwoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("molq vavedete dva stringa:");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine("Dali stringa "+b+" se sadarja v string "+a+" ? "+a.Contains(b));
        }
    }
}

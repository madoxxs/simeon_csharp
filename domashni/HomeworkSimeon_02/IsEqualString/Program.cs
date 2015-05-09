using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsEqualString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq vavedete string : ");
            string a = Console.ReadLine();
            bool b = a.Equals("Hello");
            Console.WriteLine("Ednakvi li sa izrazite ? "+ b);
        }
    }
}

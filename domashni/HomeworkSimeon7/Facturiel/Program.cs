using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Facturiel
{
    class Program
    {
        static BigInteger Fac(int n)
        {
            if (n == 0 )
            {
                return 1;
            }
            else
            {
                return n * Fac(n - 1);
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Fac(int.Parse(Console.ReadLine())));
        }
    }
}

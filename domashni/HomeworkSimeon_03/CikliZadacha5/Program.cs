using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CikliZadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq vavedete dve chisla:");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger result = 1;//0!=1;

            for (int i = k; i > 0; i--)
            {
                result = result * i;
            }
            for (int i = n; i > n - k; i--)
            {
                result = result * i;
            }

            Console.WriteLine("Rezultata ot delenieto na " + n + "!*" + k + "! s ("+n+"-"+k+")! e :" + result);

        }
    }
}

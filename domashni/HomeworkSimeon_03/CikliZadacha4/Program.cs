using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace CikliZadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq vavedete dve chisla(Parvoto da bude po-golqmo ot vtoroto):");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

           BigInteger result = 1;//0!=1;

            for (int i = n; i > k; i--)
            {
                result *= i;
            }

            Console.WriteLine("Rezultata ot delenieto na "+n+"! s "+k+"! e: " +result);

        }
    }
}

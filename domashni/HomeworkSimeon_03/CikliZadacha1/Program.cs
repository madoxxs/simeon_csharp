using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CikliZadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq vavedete chislo!");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

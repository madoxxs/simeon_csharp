using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CikliZadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MOlq vavedete chislo ot klaviaturata: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

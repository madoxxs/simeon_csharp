using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq vavedete dve chisla: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (b > a)
            {
                for (int i = a; i < b; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("chisloto b trqbva da e po-golqmo ot a!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("MOLQ vavedete duma!");
            string duma = Console.ReadLine();
            for (int i = duma.Length-1; i >=0; i--)
            {
                Console.Write(duma[i]+" ");
            }
            Console.WriteLine();
        }
    }
}

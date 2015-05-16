using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq vavedete polojitelno chislo:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Molq vavedete chisloto,koeto tarsite:");
            int search = int.Parse(Console.ReadLine());
            
            int index;
            for (int j = 0; j < n; j++) 
            {
                if (array[j] == search)
                {
                    index = j;
                    Console.WriteLine("indeksa na tarsenoto ot vas chislo e : " + index); 
                }
                
             
            }
           
           
        }
    }
}

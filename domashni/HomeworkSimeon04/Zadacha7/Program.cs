using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq vavedete n i m:");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] array = new int[n, m];
            int number = 1;
            for (int j = 0; j < m; j++)
            {

                for (int i = 0; i < n; i++) 
                {
                    
                        array[i, j] = number;
                        number ++;
                 }
                
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m; j++)
                {

                    Console.Write(array[i, j] + "\t");
                }
            }
        }
    }
}

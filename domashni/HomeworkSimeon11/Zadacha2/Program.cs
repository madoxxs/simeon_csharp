using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq vavedete broq na chislata");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 10000);
            }
            int start = Environment.TickCount;
            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
                Console.Write("{0} ", arr[write]);
            }
            Console.WriteLine("Vremeto za izpalnenie e " + (Environment.TickCount - (start)) + " milisekundi");
        }
    }
}

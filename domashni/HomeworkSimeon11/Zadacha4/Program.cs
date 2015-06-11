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
            Console.WriteLine("Molq vavedete broq na chislata");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 10000);
            }
            List<int> chetni = new List<int>();
            List<int> nechetni = new List<int>();
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
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    chetni.Add(arr[i]);
                    
                }
                else
                {
                    nechetni.Add(arr[i]);
                }

            }
            
            int[] arrchetni = chetni.ToArray();
            int[] arrnechetni = nechetni.ToArray();
            int start1 = Environment.TickCount;
            int temp1 = 0;

            for (int write = 0; write < arrchetni.Length; write++)
            {
                for (int sort = 0; sort < arrchetni.Length - 1; sort++)
                {
                    if (arrchetni[sort] > arrchetni[sort + 1])
                    {
                        temp1 = arrchetni[sort + 1];
                        arrchetni[sort + 1] = arrchetni[sort];
                        arrchetni[sort] = temp1;
                    }
                }
                Console.Write("{0} ", arrchetni[write]);
            }
            Console.WriteLine("Vremeto za izpalnenie e " + (Environment.TickCount - (start1)) + " milisekundi");
            Console.WriteLine();
            
            int start2 = Environment.TickCount;
            int temp2 = 0;

            for (int write = 0; write < arrnechetni.Length; write++)
            {
                for (int sort = 0; sort < arrnechetni.Length - 1; sort++)
                {
                    if (arrnechetni[sort] > arrnechetni[sort + 1])
                    {
                        temp2 = arrnechetni[sort + 1];
                        arrnechetni[sort + 1] = arrnechetni[sort];
                        arrnechetni[sort] = temp2;
                    }
                }
               
            }
            for (int i = arrnechetni.Length - 1; i > 0; i--)
            {
                Console.Write(arrnechetni[i]+" ");
            }
                Console.WriteLine("Vremeto za izpalnenie e " + (Environment.TickCount - (start2)) + " milisekundi");
            Console.WriteLine();
            
           
        }
    }
}

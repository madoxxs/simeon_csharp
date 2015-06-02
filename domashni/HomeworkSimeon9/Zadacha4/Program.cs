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
            Console.WriteLine("Molq vavedete broq na chislata: ");
            int n = int.Parse(Console.ReadLine());
            int[] example = new int[n];
            Console.WriteLine("Molq vavedete {0} chisla!", n);
            for (int i = 0; i < n; i++)
            {
                example[i] = int.Parse(Console.ReadLine());
            }
            Dictionary<int, int> array = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (array.ContainsKey(example[i]))
                {
                    array[example[i]]++;
                }
                else
                {
                    array.Add(example[i], 1);
                }
            }

            foreach (var a in array)
            {

                if (a.Value > ((array.Count / 2) + 1))
                {
                    Console.WriteLine("chisloto {0} e majorant!",a.Key);
                    break;
                }
                else
                {
                    Console.WriteLine("The majorant does not exists!");
                    break;
                }


                     
            }
        }
    }
}

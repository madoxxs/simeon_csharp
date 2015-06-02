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
            Console.WriteLine("Molq vavedete broq na chislata: ");
            int n=int.Parse(Console.ReadLine());
            int [] example=new int[n];
            Console.WriteLine("Molq vavedete {0} chisla!",n);
            for (int i = 0; i < n; i++)
            {
                example[i] = int.Parse(Console.ReadLine());
            }
            List<int> chetni = new List<int>();
            Array.Sort(example);
            int numberOcurances = 1;
            for (int i = 0; i < example.Length - 1; i++)
            {
                if (example[i] == example[i + 1])
                {
                    numberOcurances++;
                }
                else if ((numberOcurances % 2) == 0)
                {
                    chetni.Add(example[i]);
                    
                    numberOcurances = 1;
                }
            }
            for (int i = 0; i < chetni.Count; i++)
            {
                Console.Write(chetni[i]+" ");
            }
            Console.WriteLine();

            
            
        }
    }
}

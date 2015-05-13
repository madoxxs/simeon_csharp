using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CikliZadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq vavedete 5 chisla:");
          
            
            int min =int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < 5; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a < min)
                {
                    min = a;
                }

                if (a > max)
                {
                    max = a;
                }

            }

            Console.WriteLine("Nai-golqmoto chislo e : "+max+"\nNai-malkoto chislo e : "+min);
        }
    }
}

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
            int sum = 0;
            Console.WriteLine("Molq vavedete polojitelno chislo:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Molq vavedete {0} chisla!",n);
            for(int i=0;i<n;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < n; j++)
            {
                if (array[j] % 2 == 0)
                {
                    sum += array[j];
                }
            }
            Console.WriteLine("chislata v masiva sa :");
            foreach (int a in array)
            {
                Console.Write (a+"\t");

            }
            Console.WriteLine();
            Console.WriteLine("sumata na chetnite chisla e : "+sum);
        }
    }
}

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
            Console.WriteLine("Molq vavedete polojitelno chislo:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int first = 0;
            int second = 1;
            for (int i = 0; i < n; i++)
            {
                array[i] = first + second;
                first = second;
                second = array[i];
            }
            foreach(int a in array)
            {
                Console.WriteLine(a);
            }
        }
    }
}

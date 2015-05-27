using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator
{
    class Program
    {
        static int UmnojenieIntNumber(int a, int b, int c)
        {
            return a * b * c;
        }

        static void Main(string[] args)
        {
            Random rand1 = new Random();
           
            Random rand2 = new Random();
           
            Random rand3 = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                int a = rand1.Next(5, 20);
                int b = rand2.Next(50);
                int c = rand3.Next(6, 16);
                Console.WriteLine("Rezultata ot umnojenieto na trite cluchaino generirani chisla e :"+UmnojenieIntNumber(a, b, c));
            }
                
           

        }
    }
}

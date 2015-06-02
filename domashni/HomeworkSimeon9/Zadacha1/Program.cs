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
            List<int> numbers = new List<int>();
            string line=Console.ReadLine();
            while (line != string.Empty)
            {
                
                int number = int.Parse(line);
                numbers.Add(number);
                line = Console.ReadLine();
                
                
            }
            Console.WriteLine("Sumata na chilsta e : "+numbers.Sum());
            Console.WriteLine("Broqt na chislata e : "+numbers.Count);
            Console.WriteLine("Srednoaritmetichnoto e : "+(numbers.Sum()/numbers.Count));

        }
    }
}

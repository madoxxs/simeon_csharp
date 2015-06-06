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
            Console.WriteLine("molq vavedete tekst:");
            string text = Console.ReadLine();
            string[] array = text.Split(',', ':', ';', '.', '!', '?', '(', ')',' ');
            HashSet<string> hash = new HashSet<string>(array);
            foreach (var a in hash)
            {
                Console.Write(a+" ");
            }
        }
    }
}

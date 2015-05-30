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
            Console.WriteLine("molq vavedete izrecheniq!");
            string text = Console.ReadLine().ToLower();
            Console.WriteLine("Molq vavedete duma!");
            string duma = Console.ReadLine().ToLower();
            char[] znaci = new char[] { '.', '!', ';', ',', '?' };
            string[] text1 = text.Split(znaci);
            for (int i = 0; i < text1.Length; i++)
            {
                if (text1[i].Contains(duma))
                {
                    Console.WriteLine(text1[i]);
                }
                
            }
            
        }
    }
}
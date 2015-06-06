using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1Stucturi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("molq vavedete 20 dumi");
            string[] word = new string[20];
            for (int i = 0; i < 20; i++)
            {
                word[i] = Console.ReadLine();
            }
            Dictionary<string, int> example = new Dictionary<string, int>(20);
            for (int i = 0; i < 20; i++)
            {
                if (example.ContainsKey(word[i]))
                {
                    example[word[i]]++;
                }else
                {
                    example.Add(word[i], 1);
                }
            }
            foreach (var item in example)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
    }
}

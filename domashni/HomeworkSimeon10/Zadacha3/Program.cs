using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> teste = new Dictionary<string, int>();
            teste.Add("2", 0);
            teste.Add("3", 0);
            teste.Add("4", 0);
            teste.Add("5", 0);
            teste.Add("6", 0);
            teste.Add("7", 0);
            teste.Add("8", 0);
            teste.Add("9", 0);
            teste.Add("10", 0);
            teste.Add("J", 0);
            teste.Add("Q", 0);
            teste.Add("K", 0);
            teste.Add("A", 0);
            Dictionary<string, int> karti = new Dictionary<string, int>(teste);

            Console.WriteLine("Molq vavedete 5 karti ot testeto");
            string[] temp = new string[5];
            for (int i = 0; i < 5; i++)
            {
                temp[i] = Console.ReadLine().ToUpper();
            }

            for (int i = 0; i < 5; i++)
            {
                if (karti.ContainsKey(temp[i]))
                {
                    karti[temp[i]]++;
                }
                else
                {
                    Console.WriteLine("vavedeli ste nevalidna karta");
                    break;
                }
            }
            /*
            for (int i = 0; i < 5; i++)
            {
                if (karti[temp[i]] == 2)
                {
                    Console.WriteLine("vie imate chift ot " + karti[temp[i]]);
                    continue;
                }
                else if (karti[temp[i]] == 3)
                {
                    Console.WriteLine("vie imate set ot " + karti[temp[i]]);
                    continue;
                }
                else if (karti[temp[i]] == 4)
                {
                    Console.WriteLine("vie imate kare ot " + karti[temp[i]]);
                    continue;
                }
                else
                {
                    Console.WriteLine("vie nqmate nikoq ot tezi kombinacii");
                    continue;
                }
            }*/
            foreach (var item in karti)
            {
                

                if (item.Value == 2)
                {
                    Console.WriteLine("vie imate chift ot " + item.Key);
                    continue;
                }
                else if (item.Value == 3)
                {
                    Console.WriteLine("vie imate set ot " + item.Key);
                    continue;
                }
                else if (item.Value == 4)
                {
                    Console.WriteLine("vie imate kare ot " + item.Key);
                    break;
                }
                
            }

        }
    }
}

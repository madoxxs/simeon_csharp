using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Molq vavedete tekst!");
            string text = Console.ReadLine();
            Console.WriteLine("Molq vavaedete duma!");
            string duma = Console.ReadLine();
            int countOfDuma = CountSubstringsAppearances(text.ToLower(), duma.ToLower());
            Console.WriteLine("Dumata vavedena ot vas se sreshta : "+countOfDuma+" pati");
        }

         public static int CountSubstringsAppearances(string text, string duma)
        {
            if (duma.Length == 0)
            {
                return 0;
            }
            int count = 0;
            int index = 0;
            while (true)
            {
                index = text.IndexOf(duma, index);
                if (index == -1)
                {
                    break;
                }
                else
                {
                    count++;
                    index++;
                }
            }
            return count;

        }
    }
}
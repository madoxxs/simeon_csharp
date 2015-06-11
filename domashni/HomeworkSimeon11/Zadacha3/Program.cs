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
            Console.WriteLine("Molq vavedete izrechenie!");
            string text = Console.ReadLine();
            char[] separators = new char[] {' ',',','/','!','?','.','(',')','-'};
            string[] arr = text.Split(separators);
            string temp = string.Empty;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort].CompareTo(arr[sort + 1]) == 1)
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
                Console.WriteLine("{0} ", arr[write]);
            }
           
        }
    }
}

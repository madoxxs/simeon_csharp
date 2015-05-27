using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Greeting(string name)
        {
            Console.WriteLine("Greeting,{0}!",name);
        }
        static void Main(string[] args)
        {
            Greeting(Console.ReadLine());
        }
    }
}

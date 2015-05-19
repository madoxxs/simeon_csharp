using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class example
    {
        public static void Main()
        {
            pravoagalenTriagalnik example = new pravoagalenTriagalnik(3, 4);
            Console.WriteLine("hipotenizata e : "+example.Hipotenuza());
            example.Ugli();
            
        }
    }
}

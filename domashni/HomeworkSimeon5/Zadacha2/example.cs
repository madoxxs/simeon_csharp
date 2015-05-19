using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class example
    {
        public static void Main()
        {
            Car[] moni = new Car[10];
            moni[0] = new Automobile(2479, 6.7);
            moni[1] = new Automobile(1000 , 4);
            moni[2] = new Automobile(26789, 15);
            moni[3] = new Automobile(30000, 12.3);
            moni[4] = new Automobile(3544, 13);
            moni[5] = new SUV(25000, false);
            moni[6] = new SUV(23456, false);
            moni[7] = new SUV(250000, true);
            moni[8] = new SUV(279290, false);
            moni[9] = new SUV(12365, true);
            foreach (Car a in moni)
            {
                Console.WriteLine(a);
            }
        }
    }
}

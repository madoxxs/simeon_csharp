using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsZadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq vavedete vashite tochki ot intervala ot 1 do 9!");
            int a = int.Parse(Console.ReadLine());
          /*  if (a > 0 && a < 4)
            {
                Console.WriteLine("VASHITE  TOCHKI SA :"+(a*5));
            }
            else if (a > 3 && a < 7)
            {
                Console.WriteLine("VASHITE  TOCHKI SA :" + (a * 10));
            }
            else if (a > 6 && a < 10)
            {
                Console.WriteLine("VASHITE  TOCHKI SA :" + (a * 50));
            }
            else
            {
                Console.WriteLine("Molq vavedete chislo ot 1 do 9 !");
            }*/ //tova e edin variant.
            switch (a)
            {   
                case 1:
                case 2:
                case 3: 
                Console.WriteLine("Vashite tochki sa :" + (a * 5)); 
                break;
                case 4:
                case 5:
                case 6: 
                Console.WriteLine("Vashite tochki sa :" + (a * 10)); 
                break;
                case 7:
                case 8:
                case 9: 
                Console.WriteLine("Vashite tochki sa :" + (a * 50));
                break;
                default: 
                    Console.WriteLine("molq vavedete chislo ot 1 do 9 !");
                    break;
            }
        }
    }
}

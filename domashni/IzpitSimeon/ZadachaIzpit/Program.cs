using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaIzpit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq izberete opciq ot slednoto menu:\n 1.Zapiswane v fail.\n 2.Chetene ot fail.\n 3.Redaktirane na zapis.\n 4.Iztrivane na zapis.\n 5.Tarsene po stolica.\n 6.Tarsene po darjava.\n 7.Exit.\n--------------------------------------------------");
            int choice = int.Parse(Console.ReadLine());
            while (choice != 7)
            {
                
                switch (choice)
                {
                    case 1: metods.AddDanni(); break;
                    case 2: metods.ReadInfo(); break;
                    case 3: metods.RedaktiraneNaZapis(metods.Exam); break;
                    case 4: metods.IztrivaneNaZapis(metods.Exam); break;
                    case 5: metods.SearchCapitalCity(metods.Exam); break;
                    case 6: metods.SearchCountry(metods.Exam); break;
                    case 7: return;
                    default: Console.WriteLine("Моля въведете цифра от 1 до 6!"); break;

                }
                Console.WriteLine("Molq izberete opciq ot slednoto menu:\n 1.Zapiswane v fail.\n 2.Chetene ot fail.\n 3.Redaktirane na zapis.\n 4.Iztrivane na zapis.\n 5.Tarsene po stolica.\n 6.Tarsene po darjava.\n 7.Exit.\n--------------------------------------------------");
                choice = int.Parse(Console.ReadLine());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            Person one = new Teacher();
            Teacher two = new Teacher("ivan", "petkanov", 21, "biologiq");
            Console.WriteLine(two);
            Console.WriteLine(one.SayGoodDay());
            Console.WriteLine(two.SayGoodEvening());
            Console.WriteLine(one.Homework());
            Lecture three = new Lecture();
            Lecture four = new Lecture("ivana", "petkanova", 2, "TU");
            Console.WriteLine(three);
            Console.WriteLine(three.Homework());
            Console.WriteLine(four.SayGoodDay());
            four.Uprajnenie("monday");
            four.Uprajnenie("monday", 4);
            four.Uprajnenie("monday", 4,2130);
            Professor five=new Professor("kremena", "ivanova", 28, "TU","profesor");
            Console.WriteLine(five);
            Console.WriteLine(five.Homework());
            five.ProfessorInfo();
            five.ProvejdaIzpiti();
            Assistant six=new Assistant("ivailo", "petkanova", 1, "TU",true);
            Console.WriteLine(six);
            Console.WriteLine(six.Homework());
            six.IsGlavenAsistent();
            six.ProverqvaIzpiti();
            six.WriteArticles();
            List<string> example=new List<string>(5);
            example.Add("1a");
            example.Add("5e");
            example.Add("2v");
            SchoolTeacher seven = new SchoolTeacher("velichka", "stoeva", 4, "matematika", example);
            seven.Classes(example);
            seven.HaveFun();
            Console.WriteLine(seven.Homework());
            CollegeTeacher eight = new CollegeTeacher("djon", "atanasov", 16, "programirane", "sofiiski universitet ");
            Console.WriteLine(eight);
            Console.WriteLine(eight.Homework());
            Console.WriteLine(Person.count);
          
            
          
            
            
        }
    }
}

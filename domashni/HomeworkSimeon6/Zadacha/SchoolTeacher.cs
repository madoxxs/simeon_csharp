using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    internal class SchoolTeacher:Teacher
    {
        
        protected List<string> klas = new List<string>(5);

        public List<string> Klas
        {
            get { return klas; }
            set { klas = value; }
        }
        public SchoolTeacher(string name, string lastname, double ageWork, string nameSubject, List<string> klas)
            : base(name, lastname, ageWork, nameSubject)
        {
            klas = new List<string>(5);
          
        }
        public void Classes(List<string> klas)
        {
            for (int i = 0; i < klas.Count; i++)
            {
                Console.WriteLine(klas[i]);
            }
        }
        public override string Homework()
        {
            return "I sam uchitel i moga da proverqvam domashni";
        }
        public void HaveFun()
        {
            Console.WriteLine("Az moga da zabavlqvam deca!");
        }
        public override string ToString()
        {
            if (this.ageWork > 0)
            {
                return string.Format("name: {0} , lastname : {1} , ageWork : {2} , nameSubject: {3} klasove :{4}  ", name, lastName, ageWork, nameSubject, klas);
            }
            else
                return "molq vavedete polojitelen trudov staj";
            
        }
       
    }
}

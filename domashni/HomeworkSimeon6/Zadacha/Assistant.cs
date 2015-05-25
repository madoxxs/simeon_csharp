using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    internal class Assistant:Lecture
    {
        
        protected bool glavenAsistent;
        public bool GlavenAsistent
        {
            get { return glavenAsistent; }
            set { glavenAsistent = value; }
        }
        public Assistant(string name, string lastName, double ageWork, string nameUniversity, bool glavenAsistent)
            : base(name, lastName, ageWork, nameUniversity)
        {
            this.glavenAsistent = glavenAsistent;
            
        }
        public void IsGlavenAsistent()
        {
            Console.WriteLine("Az glaven asistent li sam ? "+glavenAsistent);
        }
        public void WriteArticles()
        {
            Console.WriteLine("Az moga da pisha nauchni statii!");
        }
        public override string Homework()
        {
            return "I sam asistent i moga da proverqvam domashni";
        }
        public void ProverqvaIzpiti()
        {
            Console.WriteLine("Az moga da proverqvam izpiti!");

        }
        public  override string ToString()
        {
            if (this.ageWork > 0)
            {
                return string.Format("name: {0} , lastname : {1} , ageWork : {2} ,  Ime na uversitet : {3} dali e glaven asistent  : {4} ", name, lastName, ageWork, nameUniversity, glavenAsistent);
            }
            else
                return "molq vavedete polojitelen trudov staj";
            
        }
        
    }
}

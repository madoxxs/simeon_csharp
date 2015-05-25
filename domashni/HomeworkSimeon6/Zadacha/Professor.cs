using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    internal  class Professor:Lecture
    {
       
        protected string titla;
        public string Titla
        {
            get { return titla; }
            set { titla = value; }
        }
        public Professor(string name, string lastName, double ageWork, string nameUniversity, string titla)
            : base(name,lastName,ageWork,nameUniversity)
        {
            this.titla = titla;
            
        }
        public void ProfessorInfo()
        {
            Console.WriteLine("moqta titla e {0} i az imam {1} godini trudov staj.",this.titla,this.ageWork);
        }
        public override string Homework()
        {
            return "I sam professor i moga da proverqvam domashni";
        }
        public void ProvejdaIzpiti()
        {
            Console.WriteLine("az moga da provejdam izpiti!");
        }
        public override string ToString()
        {
            if (this.ageWork > 0)
            {
                return string.Format("name: {0} , lastname : {1} , ageWork : {2} ,  Ime na uversitet : {3} titla : {4} ", name, lastName, ageWork, nameUniversity, titla);
            }
            else
                return "molq vavedete polojitelen trudov staj";
            
        }
    }
}

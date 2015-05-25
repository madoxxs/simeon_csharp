using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    internal class Teacher:Person
    {
        
        protected string nameSubject;
        public string NameSubject
        {
            get { return nameSubject; }
            set { nameSubject = value; }

        }
        public Teacher()
           
        {
            this.name = "ivana";
            this.lastName = "ivanova";
            this.ageWork = 10;
            this.nameSubject = "matematika";
            count++;

        }
        public Teacher(string name, string lastname, double ageWork, string nameSubject)
            : base(name, lastname, ageWork)
        {
            this.nameSubject = nameSubject;
            count++;
            
        }
        public override string Homework()
        {
           return "I sam uchitel i moga da proverqvam domashni";
        }
        
        public override string SayGoodDay()
        {
           return "Добър ден!";
        }
        public  string SayGoodEvening()
        {
            return "Добър вечер!";
        }
       public  override string ToString()
        {
            if (this.ageWork > 0)
            {
                return string.Format("name: {0} , lastname : {1} , ageWork : {2} , nameSubject: {3} ", name, lastName, ageWork, nameSubject);
            }
            else
                return "molq vavedete polojitelen trudov staj";
        }
      
    }
}

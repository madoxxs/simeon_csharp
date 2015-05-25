using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
     internal class CollegeTeacher:Teacher
     {
         
        protected string nameCollegeToTeach;
        public string NameCollegeToTeach
        {
            get { return nameCollegeToTeach; }
            set { nameCollegeToTeach = value; }
        }
        public CollegeTeacher(string name, string lastname, double ageWork, string nameSubject, string nameCollegeToTeach):base(name,lastname,ageWork,nameSubject)
        {
            this.nameCollegeToTeach = nameCollegeToTeach;
            
        }
        public override string Homework()
        {
            return "I sam uchitel i moga da proverqvam domashni";
        }
        public override string ToString()
        {
            if (this.ageWork > 0)
            {
                return string.Format("name: {0} , lastname : {1} , ageWork : {2} , nameSubject: {3} college : {4}  ", name, lastName, ageWork, nameSubject, nameCollegeToTeach);
            }
            else
                return "molq vavedete polojitelen trudov staj";
            
           
        }
    }
}

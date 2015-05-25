using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    internal abstract class Person
    {
        public static int count = 0;
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected string lastName;
         public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
            }
        }

         protected double ageWork;
         public double AgeWork
         {
             get { return ageWork; }
             set
             {
                 ageWork = value;
             }            
         }

         
         public Person(string name, string lastName, double ageWork)
         {
             this.name = name;
             this.lastName = lastName;
             this.ageWork = ageWork;
             count++;
         }
         public Person() : this("simeon", "prisadov", 12) { count++; }
         public  abstract string Homework();
        
         public  abstract string SayGoodDay();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
     internal class Lecture:Person
     {
         
        public static int MaxLecturePerWeek = 10;
        protected string nameUniversity;
        public string NameUniversity
        {
            get { return nameUniversity; }
            set
            {
                nameUniversity = value;
            }
        }
        public Lecture()
        {
            name = "stoil";
            lastName = "genev";
            ageWork = 12;
            nameUniversity = "TU sofia";
            count++;
            
        }
        public Lecture(string name, string lastName, double ageWork, string nameUniversity)
            : base(name, lastName, ageWork)
        {
            this.nameUniversity = nameUniversity;
            count++;
            
        }
        public override string Homework()
        {
            return "Az sam lektor i moga da proverqvam domashni";
        }
        public override string SayGoodDay()
        {
            return "Добър ден!";
        }
        public void Uprajnenie(string day)
        {
            Console.WriteLine("Imame uprajnenie v {0} .",day);
        }
        public void Uprajnenie(string day, int hour)
        {
            Console.WriteLine("imame uprajnenie v {0} ot {1} chasa.",day,hour);
        }
        public void Uprajnenie(string day, int hour, int zala)
        {
            Console.WriteLine("imame uprajnenie v {0} ot {1} chasa v zala {2} .", day, hour,zala);
        }
        public override string ToString()
        {
            if (this.ageWork > 0)
            {
                return string.Format("name: {0} , lastname : {1} , ageWork : {2} ,  Ime na uversitet : {3} ", name, lastName, ageWork, nameUniversity);
            }
            else
                return "molq vavedete polojitelen trudov staj";
            
        }

    }
}

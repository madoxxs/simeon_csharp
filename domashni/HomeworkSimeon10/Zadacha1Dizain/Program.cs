using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1Dizain
{
    class Program
    {
         class Factory
        {
            /// <summary>
            /// Decides which class to instantiate.
            /// </summary>
            
            private static Factory _instance;  //променлива за единствената инстанция на този клас
        // Конструторът е защитен и не може да бъде извикан
        protected Factory()
        {

        }

        // Единтвеният начин за инстанцииране е от тук
        public static Factory Instance()
        {
            // Използва късна инициализация (lazy initialization)
            // N.B.: Да не се използва в многонишкови приложения
            if (_instance == null)
            {
                _instance = new Factory();
            }
            return _instance;
        }
            public static Device Get(string name)
            {
                switch (name.ToLower())
                {
                    case "tablet":
                        return new Tablet("lenovo","a345",false);
                    
                    case "phone":
                        return new Phone("samsung","galaxy",true);
                    case "laptop":
                        
                    default:
                        return new Laptop("apple", "macpro", false);
                }
            }
        }
        static void Main(string[] args)
        {
            // Конструкторът е защитен -- операторът new не може да бъде извикан
            Factory s1 = Factory.Instance();
            Factory s2 = Factory.Instance();

            // Проверка за идентичност на инстанцията
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance"); //и двата обекта са една и съща инстанция на този клас
            }
            Console.WriteLine("molq vavedete imeto na ustroistvoto koeto iskate da sazdadete.Moje da izbirate mejdu tablet,phone ili laptop");
            for (int i = 0; i <3 ; i++)
            {
                var temp = Factory.Get(Console.ReadLine().ToLower());
                Console.WriteLine(temp);
            }
        }
    }
}

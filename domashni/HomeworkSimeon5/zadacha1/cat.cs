using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    class Cat
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;

        }
        public void Say()
        {
            Console.WriteLine("I am {0} and I am {1} years old.",name,age);
        }
    }
}

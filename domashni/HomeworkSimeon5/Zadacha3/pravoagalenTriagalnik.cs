using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class pravoagalenTriagalnik
    {
        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        private double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public pravoagalenTriagalnik(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double Hipotenuza()
        {
            return Math.Sqrt((a * a) + (b * b));
        }
        public void Ugli()
        {
            double alfa, beta;
            alfa = (Math.Atan((a / b))) * 57.3; 
            beta = (Math.Atan((b / a))) * 57.3;
            Console.WriteLine("Ugal alfa e raven na: {0:0.00}  gradusa , a beta e : {1:0.00} gradusa ",alfa,beta );
        }
    }
}

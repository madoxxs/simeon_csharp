using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    class celziiToFarenfaic
    {
        private double celzii;

        public double Celzii
        {
            get { return celzii; }
            set { celzii = value; }
            
        }
        public celziiToFarenfaic(double celzii)
        {
            this.celzii = celzii;
        }
        public double ConvertToFarenfait()
        {
            return (celzii * 1.8) + 32;
        }
        static void Main(string[] args)
        {
            celziiToFarenfaic moni = new celziiToFarenfaic(12.4);
            Console.WriteLine(moni.ConvertToFarenfait()+" farenhaita");
            /*
             celziiToFarenfaic moni = new celziiToFarenfaic(double.Parse(Console.ReadLine()));
            Console.WriteLine(moni.ConvertToFarenfait()+" farenhaita"); */ //tova e vtori variant kato tuka gradusite se vavejdat ot conzolata.
             
        }
    }
}

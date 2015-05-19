using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Automobile:Car
    {
        private double razhodGorivo;

        public double RazhodGorivo
        {
            get { return razhodGorivo; }
            set { razhodGorivo = value; }
        }
        public Automobile(double price,double razhodGorivo):base(price)
        {
            this.razhodGorivo = razhodGorivo;
        }
        public override string ToString()
        {
            return string.Format("price : {0} razhod: {1} ", price,razhodGorivo);
        }
    }
}

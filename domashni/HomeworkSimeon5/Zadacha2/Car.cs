using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Car
    {
        protected double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public Car(double price)
        {
            this.price = price;
        }
        public override string ToString()
        {
            return string.Format("price : {0} ", price);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class SUV:Car
    {
        private bool visokoprohodim;

        public bool Visokoprohodim
        {
            get { return visokoprohodim; }
            set { visokoprohodim = value; }
        }
        public SUV(double price, bool visokoprohodim)
            : base(price)
        {
            this.visokoprohodim = visokoprohodim;
        }
        public override string ToString()
        {
            return string.Format("price : {0} visokoprohodim : {1} ", price,visokoprohodim);
        }
    }
}

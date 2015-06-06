using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1Dizain
{
    class Device
    {
        internal string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        internal string marka;

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public Device(string marka, string model)
        {
            this.model = model;
            this.marka = marka;
        }
        public override string ToString()
        {
            return string.Format("marka: {0} model: {1} ", marka,model);
        }
    }
}

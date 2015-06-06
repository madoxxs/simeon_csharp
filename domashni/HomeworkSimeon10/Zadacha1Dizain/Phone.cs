using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1Dizain
{
    class Phone:Device
    {
        private bool kamera;

        public bool Kamera
        {
            get { return kamera; }
            set { kamera = value; }
        }
        public Phone(string marka, string model, bool kamera)
            : base(marka, model)
        {
            this.kamera = kamera;
        }
        public override string ToString()
        {
            return string.Format("marka: {0} model: {1} ima li kamera : {2} ", marka, model, kamera);
        }
    }
}

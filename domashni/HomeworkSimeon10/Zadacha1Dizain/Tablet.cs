using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1Dizain
{
    class Tablet:Device
    {
        private bool izdrajlivaBateria;

        public bool IzdrajlivaBateria
        {
            get { return izdrajlivaBateria; }
            set { izdrajlivaBateria = value; }
        }
        public Tablet(string marka, string model, bool izdrajlivaBateria)
            : base(marka, model)
        {
            this.izdrajlivaBateria = izdrajlivaBateria;
        }
        public override string ToString()
        {
            return string.Format("marka: {0} model: {1} izdrajliva li e bateriqta : {2} ", marka, model,izdrajlivaBateria);
        }
    }
}

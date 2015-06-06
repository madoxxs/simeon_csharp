using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1Dizain
{
    class Laptop:Device
    {
        private bool watchFilm;

        public bool WatchFilm
        {
            get { return watchFilm; }
            set { watchFilm = value; }
        }
        public Laptop(string marka, string model, bool watchFilm)
            : base(marka, model)
        {
            this.watchFilm = watchFilm;
        }
        public override string ToString()
        {
            return string.Format("marka: {0} model: {1} moje li da se gledat filmi : {2} ", marka, model, watchFilm);
        }
    }
}

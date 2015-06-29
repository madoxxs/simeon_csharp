using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaIzpit
{
    class Danni
    {
        private string capitalCity;

        public string CapitalCity
        {
            get { return capitalCity; }
            set { capitalCity = value; }
        }
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public Danni(string capitalCity, string country)
        {
            this.capitalCity = capitalCity;
            this.country = country;
        }
        public override string ToString()
        {
            return string.Format("{0}-{1}", capitalCity, country);
        }
        public Danni()
        {

        }
    }
}

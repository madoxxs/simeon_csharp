using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    class ExamplesCats
    {
        public static void Main()
        {
            Cat[] moni=new Cat [10];
            moni[0]= new Cat("ivan", 3);
            moni[1] = new Cat("petio", 2);
            moni[2] = new Cat("iva", 1);
            moni[3] = new Cat("ani", 4);
            moni[4] = new Cat("svetlio", 2);
            moni[5] = new Cat("petkan", 5);
            moni[6] = new Cat("pesho", 1);
            moni[7] = new Cat("gosho", 7);
            moni[8] = new Cat("tosho", 2);
            moni[9] = new Cat("petq", 10);
            foreach (Cat a in moni)
            {
                a.Say();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chetno_Nechetno
{
    class Program
    {
        static void ChetnoNechetno(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("CHETNO!");
            }
            else 
            {
                Console.WriteLine("NECHETNO!");
            }
        }
        static void Main(string[] args)
        {
            ChetnoNechetno(4);
            ChetnoNechetno(7);
            ChetnoNechetno(23445671);
            ChetnoNechetno(0);
        }
    }
}

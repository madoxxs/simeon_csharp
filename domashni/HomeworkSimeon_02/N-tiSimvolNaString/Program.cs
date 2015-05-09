using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_tiSimvolNaString
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("Molq vavedete string :");
            a= Console.ReadLine();
            int b;
            Console.WriteLine("Molq vavedete nomer na simvol,koito iskate da iskarate na konzolata :");
            b = int.Parse(Console.ReadLine());
            
            Console.WriteLine(b+" simbol na stringa "+a+" e : "+a[b-1]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader one = new StreamReader("text.txt"))
            {
                using (StreamWriter two = new StreamWriter("text1.txt"))
                {
                    string line = one.ReadLine();
                    char[] charsToTrim = { ',', ' ', ';','!','.',':'};
                    while (line != null)
                    {
                        string line1=line.Trim(charsToTrim);
                        two.WriteLine(line1);
                        line = one.ReadLine();
                        
                    }
                   
                }
            }
        }
    }
}

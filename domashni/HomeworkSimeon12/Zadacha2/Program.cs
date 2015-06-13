using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try{
                StreamReader moni = new StreamReader("test.txt");
                string line = moni.ReadLine();
                while (line != null)
                {
                    if (line[line.Length - 1] != '.' || line[line.Length - 1] != '?' || line[line.Length - 1] != '!')
                    {
                        throw new SentenceNotCompletedException ("greshka v punkcuaciqta na izrechenieto");

                    }
                    line = moni.ReadLine();
                }
                moni.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("failat ne e nameren");
            }
          
        }
    }
}

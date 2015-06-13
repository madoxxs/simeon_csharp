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

            using (StreamReader moni = new StreamReader("test.txt"))
            {
                try
                {
                    string line = moni.ReadLine();
                    while (line != null)
                    {
                        if (line[line.Length - 1] != '.' && line[line.Length - 1] != '?' && line[line.Length - 1] != '!')
                        {
                            
                            throw new SentenceNotCompletedException("ne ste zavarshili izrechenie");
                        }
                        line = moni.ReadLine();
                    }

                }
                catch (FileNotFoundException) 
                {
                    Console.WriteLine("failat ne e nameren");
                }
                catch(SentenceNotCompletedException e )
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}

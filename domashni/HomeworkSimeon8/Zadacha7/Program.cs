using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("test.txt"))
            {
                using (StreamWriter nechetni = new StreamWriter("nechetni.txt"))
                {
                    using (StreamWriter chetni = new StreamWriter("chetni.txt"))
                    {
                        string line = reader.ReadLine();
                        int lineNumber = 0;
                        while (line != null)
                        {
                            lineNumber++;
                            if (lineNumber % 2 == 0)
                            {
                                chetni.WriteLine(line);
                            }
                            else
                            {
                                nechetni.WriteLine(line);
                            }
                            line = reader.ReadLine();
                        }
                    }
                }
            }
        }
    }
}

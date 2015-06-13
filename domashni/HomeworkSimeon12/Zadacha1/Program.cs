using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadacha1
{
    class Program
    {
        static string ReadText(string nameFile)
        {
            StreamReader reader = new StreamReader(nameFile);
            string text = reader.ReadToEnd();
            reader.Close();
            return text;
        }
        static void WriteText(string nameFile, string text)
        {
            StreamWriter writer = new StreamWriter(nameFile,true);
            writer.WriteLine(text);
            writer.Close();
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(ReadText("test.txt")); 
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("failat ne e nameren");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Exception handling passed!");
            }
            try
            {
               WriteText("test.txt","tova e test!");
               
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Exception handling passed!");
            }
        }
    }
}

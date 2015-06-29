using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ZadachaIzpit
{
    class metods
    {
        private static List<Danni> exam = new List<Danni>();

        public static List<Danni> Exam
        {
            get { return metods.exam; }
            set { metods.exam = value; }
        }
        private static string filename = "exam.txt";

        public static string Filename
        {
            get { return metods.filename; }
            set { metods.filename = value; }
        }
        public static void AddDanni()
        {
            Console.WriteLine("vavedete stolica:");
            string capitalCity = Console.ReadLine();
            Console.WriteLine("vavedete darjava");
            string country = Console.ReadLine();
            Danni entry = new Danni(capitalCity, country);

            exam.Add(entry);
            WriteToFile(exam, filename,false);
        }
        public static void WriteToFile(List<Danni> exam, string filename,bool append)
        {
            using (StreamWriter writer = new StreamWriter(filename,append))
            {
                try
                {
                    foreach (Danni item in exam)
                    {
                        writer.WriteLine(item);
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }

            
        }
        public static void ReadInfo()
        {
            ReadFromFile(exam, filename);
        }
        public static void ReadFromFile(List<Danni> exam, string filename)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                try
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] line1 = line.Split('-');
                        Console.WriteLine("the capital city on {0} is {1}",line1[1],line1[0]);
                        line = reader.ReadLine();
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("failat {0} ne e nameren.",filename);
                }
            }
        }
        
        public static void SearchCapitalCity(List<Danni> exam)
        {
            Console.WriteLine("Molq vavedete stolicata po koqto 6te tarsite");
            string tempCapital = Console.ReadLine();
            Danni result = exam.Where(item => item.CapitalCity == tempCapital).FirstOrDefault();
            Console.WriteLine(result);
        }
        public static void SearchCountry(List<Danni> exam)
        {
            Console.WriteLine("Molq vavedete darjavata po koqto 6te tarsite");
            string tempCountry = Console.ReadLine();
            Danni  result = exam.Where(item => item.Country == tempCountry).FirstOrDefault();
            Console.WriteLine(result);
            
                
        }
        public static void RedaktiraneNaZapis(List<Danni> exam)
        {
            Console.WriteLine("Molq vavedete darjavata koqto iskate da promenite");
            string tempCountry = Console.ReadLine();
            Danni result = exam.Where(item => item.Country == tempCountry).FirstOrDefault();
            Console.WriteLine("Molq vavedete novata stolica");
            result.CapitalCity = Console.ReadLine();
            Console.WriteLine("molq vavedete novata darjava");
            result.Country = Console.ReadLine();
            WriteToFile(exam, filename, false);
        }
        public static void IztrivaneNaZapis(List<Danni> exam)
        {
            Console.WriteLine("Molq izbere koi nomer element da iztriete");
            int number = 0;
            foreach (var item in exam)
            {
                Console.WriteLine((number+1)+"."+item);
                number++;
            }
            int choice=int.Parse(Console.ReadLine());
            exam.RemoveAt(choice-1);
            
            WriteToFile(exam, filename, false);
        }
    }
}

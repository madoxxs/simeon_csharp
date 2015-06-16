using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Zadacha3
{
    class Program
    {
       
        public static void DoSomeThing()
        {
            Thread.CurrentThread.Name = "moni";

            for (int temp = 1; temp < 50000; temp++)
            {
                Console.Write(temp+" ");
                if (temp == 25000)
                {
                  Thread.Sleep(10000);
                }
            }
        }
        public static void DoSomething2()
        {
            Thread.Sleep(1300);
            for (int i = 0; i < 20; i++)
            {
                
                Console.WriteLine("Running...");
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            Thread one = new Thread(new ThreadStart(DoSomeThing));
            Thread two = new Thread(new ThreadStart(DoSomething2));
            one.Start();
            two.Start();
            one.Join();
            two.Join();
            
        }
    }
}

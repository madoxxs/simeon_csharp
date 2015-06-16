using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Zadacha2
{
    class ThreadClass
    {
        Random rand = new Random();
        public  void Task1(object aParam)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("The {0} is started", aParam);
            Console.WriteLine("I am {0} .", aParam);
            Thread.Sleep(rand.Next(1000, 10000));
            Console.WriteLine("The {0} is completed!", aParam);
        }
    }
}

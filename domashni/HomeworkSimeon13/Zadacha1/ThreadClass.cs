using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Zadacha1
{
    class ThreadClass
    {
        Random rand = new Random();
        public void Task1()
        {
            Console.WriteLine("The thread 1 is started");
            Thread.CurrentThread.Name = "Thread 1";
            Console.WriteLine("I am {0} .",Thread.CurrentThread.Name);
            Thread.Sleep(rand.Next(1000, 10000));
            Console.WriteLine("The thread 1 complete!");
        }
        public void Task2()
        {
            Console.WriteLine("The thread 2 is started");
            Thread.CurrentThread.Name = "Thread 2";
            Console.WriteLine("I am {0} .",Thread.CurrentThread.Name);
            Thread.Sleep(rand.Next(1000, 10000));
            Console.WriteLine("The thread 2 complete!");
        }
        public void Task3()
        {
            Console.WriteLine("The thread 3 is started");
            Thread.CurrentThread.Name = "Thread 3";
            Console.WriteLine("I am {0} .",Thread.CurrentThread.Name);
            Thread.Sleep(rand.Next(1000, 10000));
            Console.WriteLine("The thread 3 complete!");
        }
        public void Task4()
        {
            Console.WriteLine("The thread 4 is started");
            Thread.CurrentThread.Name = "Thread 4";
            Console.WriteLine("I am {0} .",Thread.CurrentThread.Name);
            Thread.Sleep(rand.Next(1000, 10000));
            Console.WriteLine("The thread 4 complete!");
        }
        public void Task5()
        {
            Console.WriteLine("The thread 5 is started");
            Thread.CurrentThread.Name = "Thread 5";
            Console.WriteLine("I am {0} .",Thread.CurrentThread.Name);
            Thread.Sleep(rand.Next(1000, 10000));
            Console.WriteLine("The thread 5 complete!");
        }
    }
}

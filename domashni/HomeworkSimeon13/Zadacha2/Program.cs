using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Zadacha2
{
    class Program
    {
        const int TASKS_COUNT =5;
       
       
        static void Main()
        {
            ThreadClass thread = new ThreadClass();
            Console.WriteLine("Press [Enter] to exit.");
           
            for (int i = 1; i <= TASKS_COUNT; i++)
            {
                string taskName = "Task " + i;
                ThreadPool.QueueUserWorkItem(new
                   WaitCallback(thread.Task1), taskName);
            }

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadClass example = new ThreadClass();
            Thread one = new Thread(new ThreadStart(example.Task1));
            Thread two = new Thread(new ThreadStart(example.Task2));
            Thread three = new Thread(new ThreadStart(example.Task3));
            Thread four = new Thread(new ThreadStart(example.Task4));
            Thread five = new Thread(new ThreadStart(example.Task5));
            one.Start();
            two.Start();
            three.Start();
            four.Start();
            five.Start();
        }
    }
}

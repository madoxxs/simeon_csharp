using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 6];
            int number = 30;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {

                    array[i, j] = number;
                    number--;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 6; j++)
                {

                    Console.Write(array[i, j] + "\t");
                }
            }
        }
    }
}

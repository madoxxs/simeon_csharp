﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimetricNumbers
{
    class Program
    {
        static void SimetricNumbers()
        {
            for (int i = 10; i < 1000; i++)
            {
                if (i > 10 && i < 100)
                {
                    if (i % 11 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (i > 100 && i < 1000)
                {
                    if (i / 100 == i % 10)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            SimetricNumbers();
        }
    }
}

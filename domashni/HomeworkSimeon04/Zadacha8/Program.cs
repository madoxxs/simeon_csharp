using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molq vavedete chislo : ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int numConcentricSquares = (int)Math.Ceiling((n) / 2.0);
            int j;
            int sideLen = n;
            int currNum = 0;

            for (int i = 0; i < numConcentricSquares; i++)
            {

                // obhojda gornata chast
                for (j = 0; j < sideLen; j++)
                {
                    matrix[i, i + j] = ++currNum;
                }
                //obhojda dqsnata  chast
                for (j = 1; j < sideLen - 1; j++)
                {
                    matrix[i + j, n - 1 - i] = ++currNum;
                }

                // obhojda dolnata chast
                for (j = sideLen - 1; j > 0; j--)
                {
                    matrix[n - 1 - i, i + j] = ++currNum;
                }

                //obhojda lqvata chast
                for (j = sideLen - 1; j > 0; j--)
                {
                    matrix[i + j, i] = ++currNum;
                }

                sideLen -= 2;
                

            }
            for (int t = 0; t < matrix.GetLength(0); t++)
            {

                for (int r = 0; r < matrix.GetLength(1); r++)
                {
                    Console.Write("{0,4} ", matrix[t, r]);
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("molq vavedete K ot klaviaturata:");
            int k = int.Parse(Console.ReadLine());
            if (k < 16)
            {
                int[] moni1 = new int[k];
                moni1[0] = 1;
                for (int i = 1; i < k; i++)
                {
                    moni1[i] = 2 * moni1[i - 1] + 3;
                }
                HashSet<int> example = new HashSet<int>(moni1);
                int[] moni2 = new int[k];
                moni2[0] = 2;
                for (int i = 1; i < k; i++)
                {
                    moni2[i] = 3 * moni1[i - 1] + 1;
                }
                HashSet<int> example1 = new HashSet<int>(moni2);
                int[] moni3 = new int[k];
                moni2[0] = 2;
                for (int i = 1; i < k; i++)
                {
                    moni2[i] = 2 * moni1[i - 1] - 1;
                }
                HashSet<int> example2 = new HashSet<int>(moni2);

                int[] intersectResult = example.Intersect(example1).ToArray();
                int[] intersectResult1 = example.Intersect(example2).ToArray();
                int[] intersectResult2 = example1.Intersect(example2).ToArray();
                int[] intersectResult3 = example.Intersect(example1.Intersect(example2)).ToArray();
                int[] unionResult = example.Union(example1).ToArray();
                int[] unionResult1 = example.Union(example2).ToArray();
                int[] unionResult2 = example1.Union(example2).ToArray();
                int[] unionResult3 = example.Union(example1.Union(example2)).ToArray();

                foreach (var item in intersectResult)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                foreach (var item in intersectResult1)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                foreach (var item in intersectResult2)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                foreach (var item in intersectResult3)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                foreach (var item in unionResult)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                foreach (var item in unionResult1)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                foreach (var item in unionResult2)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                foreach (var item in unionResult3)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("molq vavedete chislo po-malko ot 16");
            }
        }
    }
}

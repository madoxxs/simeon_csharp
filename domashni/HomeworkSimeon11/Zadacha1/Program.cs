using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Molq vavedete broq na chislata");
            int n=int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 10000);
            }
            int start = Environment.TickCount;
            BucketSort(arr);
            Console.WriteLine("Vremeto za izpalnenie e "+(Environment.TickCount-(start))+" milisekundi");
        } 
        public static void BucketSort(int[] integers)
        {
            //Verify input
            if (integers == null || integers.Length == 0)
                return;
            //Find the maximum and minimum values in the array
            int maxValue = integers[0]; //start with first element
            int minValue = integers[0];
            //Note: start from index 1
            for (int i = 1; i < integers.Length; i++)
            {
                if (integers[i] > maxValue)
                    maxValue = integers[i];
                if (integers[i] < minValue)
                    minValue = integers[i];
            }
            //Create a temporary "bucket" to store the values in order
            //each value will be stored in its corresponding index
            //scooting everything over to the left as much as possible (minValue)
            //e.g. 34 => index at 34 - minValue
            List<int>[] bucket = new List<int>[maxValue - minValue + 1];
            //Initialize the bucket
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }
            //Move items to bucket
            for (int i = 0; i < integers.Length; i++)
            {
                bucket[integers[i] - minValue].Add(integers[i]);
            }
            //Move items in the bucket back to the original array in order
            int k = 0; //index for original array
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        integers[k] = bucket[i][j];
                        k++;
                    }
                }
            }
            foreach (int a in integers)
            {
                Console.Write(a+" ");
            }
        }
    }
}

    

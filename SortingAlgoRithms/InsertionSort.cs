using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgoRithms
{
    internal class InsertionSort
    {
        public static void Insertion_Sort(int[]arr,int n)
        {
            for(int i = 0; i < n; i++)
            {
                int j = i;
                while(j>0 && arr[j - 1] > arr[j])
                {
                    int temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;
                    j--;
                }
            }
            foreach (var item in arr)
            {
                Console.Write(item+", ");
            }
            Console.WriteLine();
        }

    }
}

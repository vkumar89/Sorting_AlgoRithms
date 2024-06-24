using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgoRithms
{
    internal class SelectionSort
    {
        public static void Selection_Sort(int[] arr, int n)
        {
            int min = int.MaxValue;
            int ind = 0;
            for(int i = 0; i < n - 1; i++)
            {
                for(int j= i; j < n; j++)
                {
                    if (min > arr[j])
                    {
                        min = Math.Min(arr[j], min);
                        ind = j;
                    }
                }
                int temp = arr[i];
                arr[i] = min;
                arr[ind]= temp;
                min = int.MaxValue;
            }
            
        }
    }
}

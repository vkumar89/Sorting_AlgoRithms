using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgoRithms
{
    internal class BubbleSort
    {
        public static void Bubble_Sort(int[]arr,int n)
        {
            int didswap = 0;
            for(int i=0;i<n;i++)
            {
                for(int j = 1; j < n - 1; j++)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j - 1];
                        arr[j-1]= arr[j];
                        arr[j] = temp;
                        didswap = 1;
                    }
                }
                if (didswap == 0) break;
            }
        }
    }
}

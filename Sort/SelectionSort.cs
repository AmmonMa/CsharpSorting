using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosAvancados.Sort
{
    public static class SelectionSort
    {
        public static int[] Sort(int[] arr, int N)
        {
            for(int i = 0; i < N  - 1; i++)
            {
                int smallest = i;
                for( int j = i + 1; j < N; j++ )
                {
                    if(arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                int temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }

            return arr;

        }
    }
}

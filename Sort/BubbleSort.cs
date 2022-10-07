using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosAvancados.Sort
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] arr)
        {
            int procede = 0, aux = 0, end = arr.Length;

            do
            {
                procede = 0;
                for(int i = 0; i < end - 1; i++)
                {
                    if(arr[i] > arr[i + 1])
                    {
                        aux = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = aux;
                        procede = i;
                    }
                }
                for(int j = end - 1; j > 0; j--)
                {
                    if(arr[j] < arr[j - 1])
                    {
                        aux = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = aux;
                        procede = j;
                    }
                }
                end--;
            }
            while (procede != 0);
            return arr;
        }

    }
}

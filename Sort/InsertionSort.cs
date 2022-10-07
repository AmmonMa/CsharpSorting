using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosAvancados.Sort
{
    public static class InsertionSort
    {

        public static int[] Sort(int[] arr)
        {
            int aux;
            int i;
            int j;

            for (i = 1; i < arr.Length; i++)
            {
                aux = arr[i];
                for (j = i; (j > 0) && (aux < arr[j - 1]); j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[j] = aux;
            }

            return arr;
        }
    }
}

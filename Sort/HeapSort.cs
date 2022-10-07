using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosAvancados.Sort
{
    public class HeapSort
    {
        public int[] Arr { get; set; }
        public int[] Sort()
        {
            int i, aux;
            for(i = (Arr.Length - 1)/ 2; i >= 0; i--)
            {
                HeapCreate(i, Arr.Length - 1);
            }
            for(i = Arr.Length-1; i >= 1; i--)
            {
                aux = Arr[0];
                Arr[0] = Arr[i];
                Arr[i] = aux;
                HeapCreate(0, i - 1);
            }

            return Arr;
        }

        private void HeapCreate(int start, int end)
        {
            int aux = Arr[start];
            int j = start * 2 + 1;
            while(j <= end)
            {
                if (j < end)
                {
                    if (Arr[j] < Arr[j + 1])
                    {
                        j = j + 1;
                    }
                }
                if(aux < Arr[j])
                {
                    Arr[start] = Arr[j];
                    start = j;
                    j = 2 * start + 1;
                }
                else
                {
                    j = end + 1;
                }
            }
            Arr[start] = aux;
        }
    }
}

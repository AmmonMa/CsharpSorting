using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosAvancados.Search
{
    public static class BinarySearch
    {
        public static int Search(int[] arr, int el)
        {
            int end = arr.Length - 1;
            int start = 0;

            while(start <= end)
            {
                int middle = (end + start) / 2;
                if(arr[middle] < el)
                {
                    start = middle + 1;
                }
                else
                {
                    if(arr[middle] > el)
                    {
                        end = middle - 1;
                    }
                    else
                    {
                        return middle;
                    }
                }
            }
            return -1;
        }
    }
}

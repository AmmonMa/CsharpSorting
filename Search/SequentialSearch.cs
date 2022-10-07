using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosAvancados.Search
{
    public static class SequentialSearch
    {
        public static int Search(int[] arr, int el)
        {
            for( int i = 0; i < arr.Length; i++ )
            {
                if( arr[i] == el )
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

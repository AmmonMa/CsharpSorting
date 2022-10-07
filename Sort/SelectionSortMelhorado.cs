using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosAvancados.Sort
{
    public static class SelectionSortMelhorado
    {
        public static int[] Sort(int[] arr, int N)
        {
            for(int i = 0; i <= N - 1; i++)                     //O(n)
            {

                int?[] queue = new int?[N];                     //O(n)          
                int smallest = arr[i];                          //O(n)
                for ( int j = i + 1; j < N; j++ )               //O(n²)
                {       
                    if(arr[j] < smallest)                       //O(n²)
                    {
                        smallest = arr[j];
                    }
                }

                int queueIndex = 0;                             //O(n)
                for( int k = i ; k <= N - 1; k++ )              //O(n²)
                {
                    if(arr[k] == smallest)                      //O(n²)
                    {
                        queue[queueIndex] = k;
                        queueIndex++;
                    }
                }

                int move = 0;                                   //O(n)
                for( int l = 0; l < N - 1; l++ )                //O(n²)
                {
                    if(queue[l] != null)                        //O(n²)
                    {
                        int temp = arr[(int)queue[l]];
                        arr[(int)queue[l]] = arr[i + move];
                        arr[i + move] = temp;
                        move++;
                    }
                }
                if(move > 0)                                    //O(n)
                {
                    i += move - 1;
                }
            }

            return arr;
        }                                                       //6( O(n) + O(n²) )
    }
}

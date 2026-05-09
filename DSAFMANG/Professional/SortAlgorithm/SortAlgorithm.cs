using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAFMANG.Professional.SortAlgorithm
{
    public class SortAlgorithm
    {
        public int[] SortingByBruteAlgorithm(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                int minValue=arr[i];
                int minIndex=i;
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[j]<minValue)
                    {
                        minValue = arr[j];
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
    }
}

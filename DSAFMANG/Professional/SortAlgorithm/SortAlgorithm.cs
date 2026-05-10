using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAFMANG.Professional.SortAlgorithm
{
    public class SortAlgorithm
    {
        /// <summary>
        /// Note: Bubble Sort is a simple comparison-based sorting algorithm that repeatedly 
        /// swaps adjacent elements if they are in the wrong order. 
        /// It’s easy to understand but inefficient 
        /// for large datasets, with a worst-case time complexity of O(n2).
        /// 
        /// How Bubble Sort Works
        /// 	Compare the first two elements. If the first is greater, swap them.
        /// 	Move to the next pair and repeat until the end of the array.
        /// 	After the first pass, the largest element “bubbles up” to the end.
        /// 	Repeat passes until the array is sorted.
        /// 	If no swaps occur in a pass, the algorithm stops early.
        /// 
        /// Explanation of Steps
        /// 	Outer Loop → Runs n−1 passes over the array.
        /// 	Inner Loop → Compares adjacent elements and swaps if needed.
        /// 	Swap Operation → Moves larger elements toward the end.
        /// 	Optimization → If no swaps occur in a pass, stop early.
        /// 	Result → Sorted array in ascending order.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] BubbleSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            for(int i=0; i<n-1; i++)
            {
                bool isSwapped = false;
                for(int j=0; j<n-1-i; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        isSwapped = true;
                        var temp=arr[j];
                        arr[j] = arr[j + 1];
                        arr[j+1]=temp;
                    }
                }
                if (!isSwapped)
                {
                    break;
                }
            }
            return arr;
        }

        /// <summary>
        /// Selection Sort is a simple comparison-based sorting algorithm. 
        /// It works by repeatedly finding the minimum element from the 
        /// unsorted portion of the array and placing it at the beginning
        /// 
        /// How Selection Sort Works
        /// 	Outer Loop → Start from the first element and move through the array.
        /// 	Find Minimum → In each pass, search the smallest element in the remaining unsorted part.
        /// 	Swap Operation → Swap that minimum element with the first element of the unsorted part.
        /// 	Repeat Process → Continue until all elements are sorted.
        /// 	Result → Sorted array in ascending order.
        /// 
        /// Step-by-Step Explanation
        /// 	Start Outer Loop
        /// o	Begin at the first element of the array.
        /// o	This loop runs n−1 times (where n is the number of elements).
        /// 
        /// 	Find Minimum
        /// o	In each pass, assume the current element is the minimum.
        /// o	Compare it with the rest of the unsorted elements.
        /// o	Update the index if a smaller element is found.
        /// 
        /// 	Swap Operation
        /// o	Swap the smallest element found with the first element of the unsorted portion.
        /// o	After the swap, the first element of that pass is now in its correct position.
        /// 
        /// 	Repeat Process
        /// o	Move to the next position and repeat the process until all elements are sorted.
        /// o	At the end of all passes, the array is sorted in ascending order.
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] SelectionSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for(int j=i+1; j<n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                var temp= arr[minIndex];
                arr[minIndex]=arr[i];
                arr[i]=temp;
            }
            return arr;
        }
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

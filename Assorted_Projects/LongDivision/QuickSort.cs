using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongDivision
{
    class QuickSort
    {
        public static int[] sort(int[] arr,int pivotIndex,int point1,int point2)
        {
            if (point2 == pivotIndex - 1)
            {
                swap(arr, point1, pivotIndex);
                return arr;
            }
            if (point2 == 0)
            {
                pivotIndex = movePivotToEnd(arr, pivotIndex);
            }
            if(arr[point2] > arr[pivotIndex])
            {
                swap(arr, point2, point2+1);
                point1 = point2;
            }
            return sort(arr,pivotIndex, point1, point2+1);
        }
        public static int[] sort1(int[] arr, int pivotIndex)
        {
            if (arr.Length == 0)
                return arr;

            pivotIndex = movePivotToEnd(arr, pivotIndex);
            var point1 = 0;
            for(int point2 = 0; point2 < arr.Length; point2++)
            {
                if (arr[point2] > arr[pivotIndex])
                {
                    swap(arr, point2, point2 + 1);
                    point1 = point2;
                    point2 += 1;
                }
            }
            swap(arr, point1, pivotIndex);
            var newSet = arr.Skip(pivotIndex - 1).ToArray();
            pivotIndex = getPivotIndex(newSet);
            return sort1(newSet, pivotIndex);
        }
        public static int getPivotIndex(int[] arr)
        {
            var length = arr.Length;
            if (length % 2 == 0)
                return length / 2;

            return (length -1) /2;
        }
        private static int movePivotToEnd(int[] arr,int pivotindex)
        {
            var temp = arr[pivotindex];
            arr[pivotindex] = arr[arr.Length - 1];
            arr[arr.Length - 1] = temp;
            return arr.Length - 1;
        }
        private static void swap(int[] arr, int index1, int index2)
        {
            var temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
        static int Partition(int[] arr,int left,int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while(arr[left] < pivot)
                {
                    left += 1;
                }
                while(arr[right] > pivot)
                {
                    right -= 1;
                }
                if (left < right)
                {
                    swap(arr, left, right);
                }
                else
                    return right;
            }
        }
        public static void quicksort(int[] arr,int left,int right)
        {
            int pivot;
            if(left < right)
            {
                pivot = Partition(arr, left, right);
                if(pivot > 1)
                {
                    quicksort(arr, left, pivot - 1);
                }
                Console.WriteLine(pivot);
                if(pivot + 1 < right)
                {
                    Console.WriteLine("Lines");
                    log(arr);
                    quicksort(arr, pivot + 1, right);
                }
            }
        }
        static void log(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine("");
        }
    }
}

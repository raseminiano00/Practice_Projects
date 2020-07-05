using System;
using System.Linq;

namespace LongDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteMatrix();
            Console.ReadLine();
        }
        private static void ExecuteMatrix()
        {
            var b = new int[,] { { 1,8}, {2,2} ,{ 3,4} };

            var a = new int[,] { { 6,5,9}, { 7,10,4} };
            var calculated = Matrix.multiplyMatrices2(a, b);

            for (int row=0;row < calculated.GetLength(0); row++)
            {
                for (int column = 0;column < calculated.GetLength(1); column++)
                {
                    Console.Write(calculated[row,column]+",");
                }
                Console.WriteLine();
            }
        }
        private static void ExecuteQuickSort()
        {
            var arr = new int[] { 1029, 110, 1150, 2250,24,1 };
            QuickSort.quicksort(arr,0,arr.Length-1);
            foreach (int i in arr)
            {
                Console.WriteLine("Elements: " + i);
            }
        }
        private static void ExecuteBubbleSort()
        {
            var arr = new int[] { 5, 1, 10, 6 };
            var arrSize = arr.Length;
            foreach (int i in
            bubbleSort(arr, arrSize))
            {
                Console.WriteLine("Elements: " + i);
            }
        }
        static int[] bubbleSort(int[] arr,int size)
        {
            if(size == 0)
            {
                return arr;
            }
            innerBubbleSort(arr, 0);
            return bubbleSort(arr, size - 1);
        }
        static int[] innerBubbleSort(int[] arr,int index)
        {
            if (index >= arr.Length-1)
                return arr;

            if(arr[index] > arr[index+1])
                swap(arr, index, index + 1);

            innerBubbleSort(arr, index + 1);

            return arr;
        }
        static void swap(int[] arr,int index1,int index2)
        {
            var temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }



    }
}

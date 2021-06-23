using System;

namespace MergeSort
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] arr = { 11 , 15, 17 ,3, 2 ,13 };
            Console.WriteLine("Given Array");
            MergeSort.printArray(arr);
            MergeSort ob = new MergeSort();
            ob.sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            MergeSort.printArray(arr);
        }
    }
}

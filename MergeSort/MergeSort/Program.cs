using System;

namespace MergeSort
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Given Array");
            MergeSort.printArray(arr);
            MergeSort ob = new MergeSort();
            ob.sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            MergeSort.printArray(arr);
        }
    }
}

// C# program for Merge Sort
using System;

namespace MergeSort
{
    class MergeSort
    {
        void merge(int[] arr, int left, int middle, int right)
        {
            int numberLeft = middle - left + 1;
            int numberRight = right - middle;

            // Create temp arrays
            int[] LeftArray = new int[numberLeft];
            int[] RightArray = new int[numberRight];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < numberLeft; ++i)
                LeftArray[i] = arr[left + i];
            for (j = 0; j < numberRight; ++j)
                RightArray[j] = arr[middle + 1 + j];
            i = 0;
            j = 0;
            int k = left;
            while (i < numberLeft && j < numberRight)
            {
                if (LeftArray[i] <= RightArray[j])
                {
                    arr[k] = LeftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = RightArray[j];
                    j++;
                }

                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < numberLeft)
            {
                arr[k] = LeftArray[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < numberRight)
            {
                arr[k] = RightArray[j];
                j++;
                k++;
            }
        }

        // Main function that
        // sorts arr[l..r] using
        // merge()
        public void sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                sort(arr, l, m);
                sort(arr, m + 1, r);
                merge(arr, l, m, r);
            }
        }
        public static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }

    // This code is contributed by Princi Singh
}
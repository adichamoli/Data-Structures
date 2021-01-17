using System;

namespace MergeSort
{
    class Program
    {
        static void merge(int[] arr, int left, int mid, int right)
        {
            int i = 0, j = 0, k = 0;
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] first = new int[n1];
            int[] second = new int[n2];

            for (i = 0; i < n1; i++)
                first[i] = arr[left + i];

            for (i = 0; i < n2; i++)
                second[i] = arr[mid + i + 1];

            i = 0;
            j = 0;
            k = left;

            while( i < n1 && j < n2)
            {
                if(first[i] <= second[j])
                {
                    arr[k] = first[i];
                    i++;
                }
                else
                {
                    arr[k] = second[j];
                    j++;
                }
                k++;
            }

            while( i < n1)
            {
                arr[k] = first[i];
                i++;
                k++;
            }

            while (i < n2)
            {
                arr[k] = second[i];
                i++;
                k++;
            }
        }

        static void mergeSort(int[] arr, int left, int right)
        {
            int mid = -1;

            if( left < right)
            {
                mid = left + (right - left) / 2;

                mergeSort(arr, left, mid);
                mergeSort(arr, mid + 1, right);

                merge(arr, left, mid, right);
            }
        }

        static void display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }

        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("UnSorted array");
            display(arr);

            mergeSort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            display(arr);
        }
    }
}

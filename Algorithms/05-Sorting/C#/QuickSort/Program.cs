using System;

namespace QuickSort
{
    class Program
    {
        static void swap(ref int num1, ref int num2)
        {
            int newnum;

            newnum = num1;
            num1 = num2;
            num2 = newnum;
        }

        static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for( int j = low; j < high; j++)
            {
                if(arr[j] < pivot)
                {
                    i++;

                    swap(ref arr[i], ref arr[j]);
                }
            }

            swap(ref arr[i + 1], ref arr[high]);
            return i + 1;
        }

        static void quickSort(int[] arr, int low, int high)
        {
            int pivot = -1;
            if (low < high)
            {
                pivot = partition(arr, low, high);

                quickSort(arr, low, pivot - 1);
                quickSort(arr, pivot + 1, high);
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

            quickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            display(arr);
        }
    }
}

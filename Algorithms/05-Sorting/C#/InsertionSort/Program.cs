using System;

namespace InsertionSort
{
    class Program
    {
        static void insertionSort(int[] arr)
        {
            int size = arr.Length;
            int key = -1;
            int i =0, j = 0;

            for (i = 1; i < size; i++)
            {
                key = arr[i];
                j = i - 1;

                while(j >=0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
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

            insertionSort(arr);
            Console.WriteLine("\nSorted array");
            display(arr);
        }
    }
}

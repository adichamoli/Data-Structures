using System;

namespace SelectionSort
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

        static void selectionSort(int[] arr)
        {
            int size = arr.Length;
            int min_index = -1;

            for (int i = 0; i < size - 1; i++)
            {
                min_index = i;
                for (int j = i + 1; j < size; j++)
                    if (arr[min_index] > arr[j])
                        min_index = j;

                swap(ref arr[i], ref arr[min_index]);
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

            selectionSort(arr);
            Console.WriteLine("\nSorted array");
            display(arr);
        }
    }
}

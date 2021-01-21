using System;

namespace RadixSort
{
    class Program
    {
        static int getMax(int[] arr)
        {
            int size = arr.Length;
            int max = arr[0];
            int i = 0;

            for (i = 1; i < size; i++)
                if (arr[i] > max)
                    max = arr[i];

            return max;
        }

        static void countSort(int[] arr, int exp)
        {
            int size = arr.Length;
            int[] output = new int[size];
            int[] count = new int[10];
            int i = 0;

            for (i = 0; i < 10; i++)
                count[i] = 0;

            for (i = 0; i < size; i++)
                count[(arr[i] / exp) % 10]++;

            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            for (i = size - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            for (i = 0; i < size; i++)
                arr[i] = output[i];
        }

        static void radixSort(int[] arr)
        {
            int max = getMax(arr);
            int exp = 0;

            for (exp = 1; max / exp > 0; exp *= 10)
                countSort(arr, exp);
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

            radixSort(arr);
            Console.WriteLine("\nSorted array");
            display(arr);
        }
    }
}

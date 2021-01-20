using System;

namespace ShellSort
{
    class Program
    {
        static void shellSort(int[] arr)
        {
            int size = arr.Length;
            int temp = 0;
            int gap = 0;
            int i = 0;
            int j = 0;

            for( gap = size/2; gap > 0 ; gap /= 2)
            {
                for( i = gap; i < size; i++)
                {
                    temp = arr[i];
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                        arr[j] = arr[j - gap];

                    arr[j] = temp;
                }
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

            shellSort(arr);
            Console.WriteLine("\nSorted array");
            display(arr);
        }
    }
}

using System;

namespace BubbleSort
{
    class Program
    {
        static void bubbleSort(int[] arr)
        {
            int size = arr.Length;
            int temp;
            
            for(int i = 0; i < size -1; i++)
                for (int j = 0; j < size - 1 - i; j++)
                    if(arr[j] > arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

        }

        static void bubbleSortOptimized(int[] arr)
        {
            int size = arr.Length;
            int temp;
            bool swapped = false;

            for (int i = 0; i < size - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < size - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;

            }

        }

        static void display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("UnSorted array");
            display(arr);

            bubbleSort(arr);
            Console.WriteLine("Sorted array");
            display(arr);

            int[] arr2 = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("UnSorted array");
            display(arr2);

            bubbleSortOptimized(arr2);
            Console.WriteLine("Sorted array");
            display(arr2);
        }
    }
}

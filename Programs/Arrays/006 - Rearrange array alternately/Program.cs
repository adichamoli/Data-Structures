using System;

namespace RearrangeArray
{
    class Program
    {
        public static void rearrange(int[] arr, int n)
        {
            int max_idx = n - 1;
            int min_idx = 0;

            int max_ele = arr[n - 1] + 1;

            for(int i = 0; i < n; i++)
            {
                if( i % 2 == 0 )
                {
                    arr[i] += (arr[max_idx] % max_ele) * max_ele;
                    max_idx--;
                }
                else
                {
                    arr[i] += (arr[min_idx] % max_ele) * max_ele;
                    min_idx++;
                }
            }

            for (int i = 0; i < n; i++)
                arr[i] = arr[i] / max_ele;
        }
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int n = arr.Length;
            Console.WriteLine("Original Array");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            rearrange(arr, n);

            Console.WriteLine("Modified Array");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }
    }
}

using System;

namespace KadaneAlgorithm
{
    class Program
    {
        static int maxSubArraySum(int[] arr, int n)
        {
            int max_so_far = arr[0];
            int curr_max = arr[0];

            for(int i = 0; i < n; i++)
            {
                curr_max = Math.Max(arr[i], curr_max + arr[i]);
                max_so_far = Math.Max(max_so_far, curr_max);
            }

            return max_so_far;
        }
        static void Main(string[] args)
        {
            int[] a = { -2, -3, 4, -1, -2, 1, 5, -3 };
            int n = a.Length;
            Console.Write("Maximum contiguous sum is " + maxSubArraySum(a, n));
        }
    }
}

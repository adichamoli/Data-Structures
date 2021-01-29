using System;

namespace FindWater
{
    class Program
    {
        static int findWater(int[] arr, int n)
        {
            int[] left = new int[n];
            int[] right = new int[n];
            int water = 0;

            left[0] = arr[0];
            for (int i = 1; i < n; i++)
                left[i] = Math.Max(left[i - 1], arr[i]);

            right[n - 1] = arr[n - 1];
            for (int i = n - 2; i >= 0; i--)
                right[i] = Math.Max(right[i + 1], arr[i]);

            for (int i = 0; i < n; i++)
                water += Math.Min(left[i], right[i]) - arr[i];

            return water;
        }

        public static void Main()
        {
            int[] arr = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            Console.WriteLine("Maximum water that can be accumulated is " + findWater(arr, arr.Length));
        }
    }
}

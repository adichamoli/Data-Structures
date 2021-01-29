using System;

namespace EquilibriumPoint
{
    class Program
    {
        static int equilibrium(int[] arr, int n)
        {
            int sum = 0;
            int leftsum = 0;

            for (int i = 0; i < n; ++i)
                sum += arr[i];

            for (int i = 0; i < n; ++i)
            {
                sum -= arr[i];

                if (leftsum == sum)
                    return i + 1;

                leftsum += arr[i];
            }

            return -1;
        }

        public static void Main()
        {
            int[] arr = { 1, 3, 5, 2, 2 };
            int arr_size = arr.Length;

            Console.Write("First equilibrium index is " +
                               equilibrium(arr, arr_size));
        }
    }
}

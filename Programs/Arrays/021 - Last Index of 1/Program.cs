using System;

namespace LastIndexOf1
{
    class Program
    {
        public static int FindIndex(int[] arr, int idx, int K)
        {
            if (idx < 0)
                return -1;

            if (arr[idx] == K)
            {
                return idx;
            }

            return FindIndex(arr, idx - 1, K);
        }

        public static void Main(String[] args)
        {
            int[] arr = new int[] { 4, 3, 7, 8, 6, 2, 1 };
            int result = FindIndex(arr, arr.Length - 1, 1);
            Console.WriteLine("Last Index of 1 : " + result);
        }
    }
}

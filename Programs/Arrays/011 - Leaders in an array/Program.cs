using System;

namespace LeadersInArray
{
    class Program
    {
        static void printLeaders(int[] arr, int size)
        {
            int max_from_right = arr[size - 1];

            Console.Write(max_from_right + " ");

            for (int i = size - 2; i >= 0; i--)
            {
                if (max_from_right <= arr[i])
                {
                    max_from_right = arr[i];
                    Console.Write(max_from_right + " ");
                }
            }
        }

        public static void Main(String[] args)
        {
            int[] arr = new int[] { 16, 17, 4, 3, 5, 2 };
            int n = arr.Length;
            printLeaders(arr, n);
        }
    }
}

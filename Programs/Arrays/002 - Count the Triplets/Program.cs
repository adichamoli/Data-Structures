using System;

namespace CountTriplets
{
    class Program
    {
        static int countTriplets(int[] arr, int n)
        {
            int[] freq = new int[100];

            for (int i = 0; i < n; i++)
                freq[arr[i]]++;

            int count = 0;

            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (freq[arr[i] + arr[j]] > 0)
                    {
                        count++;
                        Console.WriteLine("Triplet : (" +  arr[i] + "," + arr[j] + ")");
                    }

            return count;
        }
        static void Main(string[] args)
        {
            int n = 4;
            int[] arr = { 1, 5, 3, 2 };

            Console.WriteLine("No of Triplets : " + countTriplets(arr, n));
        }
    }
}

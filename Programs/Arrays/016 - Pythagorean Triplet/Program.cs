using System;

namespace PyhtagoreanTriplet
{
    class Program
    {
        static bool CheckTriplet(int[] arr, int n)
        {
            int maximum = 0;

            for (int i = 0; i < n; i++)
                maximum = Math.Max(maximum, arr[i]);

            int[] hash = new int[maximum + 1];

            for (int i = 0; i < n; i++)
                hash[arr[i]]++;

            for (int i = 1; i < maximum + 1; i++)
            {
                if (hash[i] == 0)
                    continue;

                for (int j = 1; j < maximum + 1; j++)
                {
                    if ((i == j && hash[i] == 1) || hash[j] == 0)
                        continue;

                    int val = (int)Math.Sqrt(i * i + j * j);

                    if ((val * val) != (i * i + j * j))
                        continue;

                    if (val > maximum)
                        continue;

                    if (hash[val] == 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void Main(String[] args)
        {
            int[] arr = { 3, 2, 4, 6, 5 };
            int n = arr.Length;
            if (CheckTriplet(arr, n))
                Console.Write("Yes");
            else
                Console.Write("No");
        }
    }
}

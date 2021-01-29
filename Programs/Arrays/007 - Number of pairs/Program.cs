using System;

namespace NoOfArrays
{
    class Program
    {
        static int count(int x, int[] Y, int n, int[] NoOfY)
        {
            if (x == 0)
                return 0;

            if (x == 1)
                return NoOfY[0];

            int idx = Array.BinarySearch(Y, x);
            int ans;

            if (idx < 0)
            {
                idx = Math.Abs(idx + 1);
                ans = Y.Length - idx;
            }
            else
            {
                while (idx < n && Y[idx] == x)
                    idx++;

                ans = Y.Length - idx;
            }

            ans += (NoOfY[0] + NoOfY[1]);

            if ( x == 2 )
                ans -= (NoOfY[3] + NoOfY[4]);

            if (x == 3)
                ans += NoOfY[2];

            return ans;
        }

        static int countPairs(int[] X, int[] Y, int m, int n)
        {
            int[] NoOfY = new int[5];

            for (int i = 0; i < n; i++)
                if (Y[i] < 5)
                    NoOfY[Y[i]]++;

            Array.Sort(Y);

            int total_pairs = 0;

            for (int i = 0; i < m; i++)
                total_pairs += count(X[i], Y, n, NoOfY);

            return total_pairs;
        }

        public static void Main()
        {
            int[] X = { 2, 1, 6 };
            int[] Y = { 1, 5 };

            Console.Write("Total pairs = " +
                        countPairs(X, Y, X.Length, Y.Length));
        }
    }
}

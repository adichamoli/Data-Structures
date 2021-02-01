using System;

namespace SpiralMatrix
{
    class Program
    {
        static int R = 4;
        static int C = 4;

        // Function for printing matrix in spiral
        // form i, j: Start index of matrix, row
        // and column respectively m, n: End index
        // of matrix row and column respectively
        static void print(int[,] arr, int i, int j, int m,
                          int n)
        {
            if (i >= m || j >= n)
                return;

            for (int p = i; p < n; p++)
                Console.Write(arr[i, p] + " ");

            for (int p = i + 1; p < m; p++)
                Console.Write(arr[p, n - 1] + " ");
            
            if ((m - 1) != i)
                for (int p = n - 2; p >= j; p--)
                    Console.Write(arr[m - 1, p] + " ");

            if ((n - 1) != j)
                for (int p = m - 2; p > i; p--)
                    Console.Write(arr[p, j] + " ");

            print(arr, i + 1, j + 1, m - 1, n - 1);
        }

        public static void Main(String[] args)
        {
            int[,] a = { { 1, 2, 3, 4 },
                      { 5, 6, 7, 8 },
                      { 9, 10, 11, 12 },
                      { 13, 14, 15, 16 } };

            print(a, 0, 0, R, C);
        }
    }
}

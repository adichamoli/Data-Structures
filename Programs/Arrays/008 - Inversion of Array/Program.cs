using System;

namespace CountInversions
{
    class Program
    {
        static int mergeSort(int[] arr, int size)
        {
            int[] temp = new int[size];
            return _mergeSort(arr, temp, 0, size - 1);
        }

        static int _mergeSort(int[] arr, int[] temp, int left, int right)
        {
            int mid = 0;
            int inv_count = 0;

            if ( left < right )
            {
                mid = (left + right) / 2;

                inv_count += _mergeSort(arr, temp, left, mid);
                inv_count += _mergeSort(arr, temp, mid + 1, right);

                inv_count += merge(arr, temp, left, mid + 1, right);
            }

            return inv_count;
        }

        static int merge(int[] arr, int[] temp, int left, int mid, int right)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            int inv_count = 0;

            i = k = left;
            j = mid;

            while ((i <= mid - 1) && (j <= right))
            {
                if (arr[i] < arr[j])
                    temp[k++] = arr[i++];
                else
                {
                    temp[k++] = arr[j++];
                    inv_count += (mid - i);
                }
            }

            while (i <= mid - 1)
                temp[k++] = arr[i++];

            while (j <= right)
                temp[k++] = arr[j++];

            for (i = left; i <= right; i++)
                arr[i] = temp[i];

            return inv_count;
        }

        public static void Main()
        {
            int[] arr = new int[] { 2, 4, 1, 3, 5 };
            Console.Write("Number of inversions are " + mergeSort(arr, arr.Length));
        }
    }
}

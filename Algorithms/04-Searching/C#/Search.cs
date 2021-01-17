using System;

namespace Search
{
    class Search
    {
        public static int LinearSearch(int[] arr, int value)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == value)
                    return i;
            }
            return -1;
        }

        public static int BinarySearch(int[] arr, int value, int low, int high)
        {
            int mid = 0;
            while(low <= high)
            {
                mid = low + (high - low) / 2;

                if (arr[mid] == value)
                    return mid;
                else if (arr[mid] < value)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return -1;
        }

        public static int InterpolationSearch(int[] arr, int value, int low, int high)
        {
            int mid = 0;
            while ((arr[high] != arr[low]) && (value >= arr[low]) && (value <= arr[high]))
            {
                mid = low + ((value - arr[low]) * (high - low) / (arr[high] - arr[low]));

                if (arr[mid] == value)
                    return mid;
                else if (arr[mid] < value)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return -1;
        }

        public static int BinarySearchRecursive(int[] arr, int value, int low, int high)
        {
            int mid = 0;
            if(low <= high)
            {
                mid = low + (high - low) / 2;

                if (arr[mid] == value)
                    return mid;
                else if (arr[mid] > value)
                    return BinarySearchRecursive(arr, value, low, mid - 1);
                else
                    return BinarySearchRecursive(arr, value, mid + 1, high);
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int x = 40;

            // Function call 
            int result = LinearSearch(arr, x);
            if (result == -1)
                Console.WriteLine(
                    "Element is not present in array");
            else
                Console.WriteLine("Element is present at index "
                                  + result);

            result = BinarySearch(arr, x, 0, arr.Length -1);

            if (result == -1)
                Console.WriteLine(
                    "Element is not present in array");
            else
                Console.WriteLine("Element is present at index "
                                  + result);

            result = BinarySearchRecursive(arr, x, 0, arr.Length - 1);

            if (result == -1)
                Console.WriteLine(
                    "Element is not present in array");
            else
                Console.WriteLine("Element is present at index "
                                  + result);

            result = InterpolationSearch(arr, x, 0, arr.Length - 1);

            if (result == -1)
                Console.WriteLine(
                    "Element is not present in array");
            else
                Console.WriteLine("Element is present at index "
                                  + result);
        }
    }
}

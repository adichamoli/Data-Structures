using System;

namespace SearchAlgorithms
{
    class Search
    {
        public static int LinearSearch(int[] arr, int value)
        {

            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int x = 10;

            // Function call 
            int result = LinearSearch(arr, x);
            if (result == -1)
                Console.WriteLine(
                    "Element is not present in array");
            else
                Console.WriteLine("Element is present at index "
                                  + result);
        }
    }
}

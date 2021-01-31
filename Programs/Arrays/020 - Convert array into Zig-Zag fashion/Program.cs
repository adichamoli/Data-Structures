using System;

namespace ZigZag
{
    class Program
    {
        static void ZigZag(int[] arr)
        {
            bool flag = true;

            int temp = 0;

            for (int i = 0; i <= arr.Length - 2; i++)
            {
                if (flag)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                } 
                else
                { 
                    if (arr[i] < arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }

                flag = !flag;
            }
        }

        public static void Main(String[] args)
        {
            int[] arr = new int[] { 4, 3, 7, 8, 6, 2, 1 };
            ZigZag(arr);
            foreach (int i in arr)
                Console.Write(i + " ");
        }
    }
}

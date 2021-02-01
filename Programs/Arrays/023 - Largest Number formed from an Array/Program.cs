using System;
using System.Collections.Generic;

namespace LargestNumber
{
    class LargestNumberClass
    {
        public static void
        LargestNumberMethod(List<int> inputList)
        {
            string output = string.Empty;

            List<string> newList = inputList.ConvertAll<string>(
                delegate (int i) { return i.ToString(); });

            newList.Sort(MyCompare);

            for (int i = 0; i < inputList.Count; i++)
            {
                output = output + newList[i];
            }

            if (output[0] == '0' && output.Length > 1)
            {
                Console.Write("0");
            }
            Console.Write(output);
        }

        internal static int MyCompare(string X, string Y)
        {
            string XY = X + Y;

            string YX = Y + X;

            return XY.CompareTo(YX) > 0 ? -1 : 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList
                = new List<int>() { 54, 546, 548, 60 };
            LargestNumberClass.LargestNumberMethod(inputList);
        }
    }
}

using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main()
        {
            string[] input = { "12", "aaaaaaa", "15", ".", "aa" };
            var result = GetShortStrings(input);

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }

        public static string[] GetShortStrings(string[] inputArray)
        {
            int size = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length <= 3)
                {
                    size++;
                }
            }

            string[] resultArray = new string[size];
            int j = 0;
            
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length <= 3)
                {
                    resultArray[j] = inputArray[i];
                    j++;
                }
            }

            return resultArray;
        }
    }
}
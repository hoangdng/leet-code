using System;

namespace CsharpTest
{
    class Program
    {
        public static bool CheckIfExist(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] * 2 || arr[i] * 2 == arr[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] arr = { 0, 0, 1, 2, 2 };
            Console.Write(CheckIfExist(arr));
        }
    }
}

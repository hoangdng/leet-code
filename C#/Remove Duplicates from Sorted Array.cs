using System;

namespace CsharpTest
{
    class Program
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int currentIndex = 0;
            int arrLength = nums.Length;
            if (arrLength == 0)
            {
                return currentIndex;
            }
            for (int i = 0; i < arrLength; i++)
            {
                if (nums[i] != nums[currentIndex])
                {
                    currentIndex++;
                    nums[currentIndex] = nums[i];
                }
            }
            return currentIndex + 1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 0, 0, 1, 2, 2 };
            Console.Write(RemoveDuplicates(arr));
        }
    }
}

using System;

namespace CsharpTest
{
    class Program
    {
        public static void MoveZeroes(int[] nums)
        {
            int length = nums.Length;
            int writePointer = 0;
            int readPointer = 0;
            for (; readPointer < length; readPointer++)
            {
                if (nums[readPointer] != 0)
                {
                    nums[writePointer] = nums[readPointer];
                    writePointer++;
                }
            }
            for (int i = writePointer; i < length; i++)
            {
                nums[i] = 0;
            }
            for (int i = 0; i < length; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {  2,1 };
            MoveZeroes(arr);
        }
    }
}

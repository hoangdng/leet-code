
using System;

namespace CsharpTest
{
    class Program
    {
        public static int ThirdMax(int[] nums)
        {
            Array.Sort(nums);
            int currentIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != nums[currentIndex])
                {
                    currentIndex++;
                    nums[currentIndex] = nums[i];
                }
            }
            if (currentIndex + 1 == 2)
                return nums[1];
            if (currentIndex + 1 == 1)
                return nums[0];
            return nums[currentIndex + 1 - 3];
        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 1 };
            Console.Write(ThirdMax(arr));
        }
    }
}

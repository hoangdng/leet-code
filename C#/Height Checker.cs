using System;

namespace CsharpTest
{
    class Program
    {
        public static int HeightChecker(int[] heights)
        {
            int moveSteps = 0;
            int[] cloneHeights = new int[heights.Length];
            heights.CopyTo(cloneHeights, 0);
            Array.Sort(cloneHeights);
            for (int i = 0; i < heights.Length; i++)
            {
                if (cloneHeights[i] != heights[i])
                {
                    moveSteps++;
                }
            }
            return moveSteps;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 4, 2, 1, 3 };
            Console.Write(HeightChecker(arr));
        }
    }
}
using System;

namespace CsharpTest
{
    class Program
    {
        public static bool ValidMountainArray(int[] A)
        {
            int length = A.Length;
            if (length < 3 || A[0] > A[1] || A[length - 2] > A[length - 1])
            {
                return false;
            }
            int top = 0;
            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i] > A[i + 1] && A[i] > A[i - 1])
                {
                    top++;
                }
                if (A[i] == A[i - 1] || A[i] == A[i + 1])
                {
                    return false;
                }
            }
            return top == 1 ? true : false;
        }

        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 2, 1, 2 };
            Console.Write(ValidMountainArray(arr));
        }
    }
}

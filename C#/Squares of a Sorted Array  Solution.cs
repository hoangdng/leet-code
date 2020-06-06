using System;

namespace CsharpTest
{
    class Program
    {
        public static int[] SortedSquares(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = A[i] * A[i];
            }
            int tempVal;
            for (int i = 0; i < A.Length-1; i++)
            {
                for (int j = i+1; j < A.Length; j++)
                {
                    if(A[i]>A[j])
                    {
                        tempVal = A[i];
                        A[i] = A[j];
                        A[j] = tempVal;
                    }
                }
            }
            return A;
        }
        static void Main(string[] args)
        {
            int[] arr = { -4, -1, 0, 3, 10 };
            Console.Write(SortedSquares(arr));
        }
    }
}

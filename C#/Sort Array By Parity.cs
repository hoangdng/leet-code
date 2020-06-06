public class Solution {
    public int[] SortArrayByParity(int[] A) {
            int leftPointer = 0;
            int rightPointer = A.Length - 1;
            while (leftPointer <= rightPointer)
            {
                if (A[leftPointer] % 2 != 0)
                {
                    int tempValue = A[rightPointer];
                    A[rightPointer] = A[leftPointer];
                    A[leftPointer] = tempValue;
                    rightPointer--;
                }
                else
                {
                    leftPointer++;
                }
            }
            return A;
    }
}
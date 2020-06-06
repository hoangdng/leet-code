public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (i != arr.Length - 1)
            {
                arr[i] = Math.Max(arr[i], arr[i + 1]);
            }
        }
        for (int i = 0; i < arr.Length - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
        arr[arr.Length - 1] = -1;
        return arr;
    }
}
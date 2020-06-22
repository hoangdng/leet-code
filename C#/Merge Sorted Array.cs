public class Solution {
     public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int length = m + n;
            for (int i = m; i < length; i++)
            {
                nums1[i] = nums2[i - m];
            }
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if(nums1[i]>nums1[j])
                    {
                        int temp = nums1[i];
                        nums1[i] = nums1[j];
                        nums1[j] = temp;
                    }
                }
            }
        }
}
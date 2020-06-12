public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
         
           IList<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                nums[index] = Math.Abs(nums[index]) * (-1);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    result.Add(i + 1);
                }
            }
            return result;
    }
}
public class Solution {
    public int[] BuildArray(int[] nums) {
       List<int> ans = new List<int>();
        for (int i = 0; i < nums.Length; i++) {
            ans.Add(nums[nums[i]]);
        }
        return ans.ToArray();
    }
}
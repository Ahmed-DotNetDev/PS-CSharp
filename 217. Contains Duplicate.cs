public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Array.Sort(nums);
            int size = nums.Length - 1;
for (int i = 0; i < size; i++)
{
    if (nums[i] == nums[i + 1])
    {
        return true;
    }
}
return false;
    }
}
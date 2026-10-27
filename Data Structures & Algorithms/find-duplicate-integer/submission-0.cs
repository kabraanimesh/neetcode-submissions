public class Solution {
    public int FindDuplicate(int[] nums) {
        Array.Sort(nums);

        for (int left = 0; left < nums.Length; left++) {
            if (nums[left] == nums[left+1]) {
                return nums[left];
            }
        }

        return -1;
    }
}

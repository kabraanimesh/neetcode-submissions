public class Solution {
    public bool hasDuplicate(int[] nums) {
        var map = new HashSet<int>();

        for (int i = 0; i < nums.Count(); i++) {
            if (map.Contains(nums[i])) {
                return true;
            }
            else {
                map.Add(nums[i]);
            }
        }
        return false;
    }
}
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            var rem = target - nums[i];

            if (map.ContainsKey(rem)) {
                var y = map[rem];
                return new int[] {y, i};
            }
            else {
                map[nums[i]] = i;
            }
        }

        return new int[]{0};
    }
}

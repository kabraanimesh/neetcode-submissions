public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var map = new Dictionary<int, int>();

        for (var i = 0; i < nums.Count(); i++) {
            var rem = target - nums[i];

            if (map.ContainsKey(rem)) {
                var y = map[rem];
                return new int[2]{y, i};
            }
            else {
                map[nums[i]] = i;
            }
        }

        return new int[0];
    }
}
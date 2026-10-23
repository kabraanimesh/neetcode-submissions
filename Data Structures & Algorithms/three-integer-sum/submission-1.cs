public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> result = new ();

        Array.Sort(nums);

        int n = nums.Length;

        int target = 0;

        for (int i = 0; i < n; i++) {
            if (nums[i] > 0) {
                break;
            }

            if (i > 0 && nums[i] == nums[i-1]) {
                continue;
            }

            int left = i + 1;
            int right = n -1 ;

            while (left < right) {

                int currSum = nums[i] + nums[left] + nums[right];
                if (currSum < target) {
                    left++;
                    continue;
                }

                if (currSum > target) {
                    right--;
                    continue;
                }

                if (currSum == target) {
                    result.Add(new List<int> {nums[i], nums[left], nums[right] });

                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left-1]) left++;
                    while (left < right && nums[right] == nums[right+1]) right--;
                }
            }
        }

        return result;
    }
}

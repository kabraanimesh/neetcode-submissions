public class Solution {
    public int Search(int[] nums, int target) {
        int n = nums.Length;

        int left = 0;
        int right = n - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2;

            if (target == nums[mid]) {
                return mid;
            }
            else if (target == nums[right]) {
                return right;
            }
            else if (target == nums[left]) {
                return left;
            }

            if (nums[mid] > nums[right]) {
                if (target > nums[left] && target < nums[mid]) {
                    right = mid - 1;
                }
                else {
                    left = mid + 1;
                }
            }
            else {
                if (target < nums[mid] || target > nums[right]) {
                    right = mid - 1;
                }
                else {
                    left = mid + 1;
                }
            }
        }
        return -1;
    }
}

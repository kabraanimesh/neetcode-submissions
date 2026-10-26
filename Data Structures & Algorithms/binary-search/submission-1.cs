public class Solution {
    public int Search(int[] nums, int target) {
        return BinarySearch(0, nums.Length - 1, nums, target);
    }
    public int BinarySearch(int left, int right, int[] nums, int target) {
        if (left > right) return -1;
        int mid = left + (right - left) / 2;
        if (target == nums[mid]) {
            return mid;
        }
        else if (target < nums[mid]) {
            return BinarySearch(left, mid - 1, nums, target);
        }
        return BinarySearch(mid + 1, right, nums, target);

    }
}

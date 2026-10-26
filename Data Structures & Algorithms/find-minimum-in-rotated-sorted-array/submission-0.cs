public class Solution {
    public int FindMin(int[] nums) {
        Array.Sort(nums);
        
        return BinarySearch(0, nums.Length -1, nums, nums[0]);
    }

    public int BinarySearch(int left, int right, int[] nums, int min) {
        if (left > right) {
            return min;
        }

        int mid = left + (right - left) / 2;
        
        if (nums[mid] < min) {
            min = Math.Min(nums[mid], min);
            return BinarySearch(left, mid - 1, nums, min);
        }
        else if (nums[mid] == min) {
            return min;
        }
        return BinarySearch(mid + 1, right, nums, min);
    }
}

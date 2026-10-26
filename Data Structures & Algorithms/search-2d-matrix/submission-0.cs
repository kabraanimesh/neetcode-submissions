public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {

        foreach (var mat in matrix) {
            int n = mat.Length - 1;
            if (target == mat[n]) {
                return true;
            }
            else if (target == mat[0]) {
                return true;
            }
            else if (target > mat[0] && target < mat[n]) {
                return BinarySearch(0, n, mat, target);
            }
        }
        return false;
    }

    public bool BinarySearch(int left, int right, int[] nums, int target) {
        if (left > right) return false;;

        int mid = left + (right - left) / 2;

        if (target == nums[mid]) {
            return true;
        }
        else if (target > nums[mid]) {
            return BinarySearch(mid + 1, right, nums, target);
        }
        else {
            return BinarySearch(left, mid -1, nums, target);
        }
    }

    

   
}

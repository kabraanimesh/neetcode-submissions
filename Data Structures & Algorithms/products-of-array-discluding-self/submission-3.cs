public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] answer = new int[n];
        int prefix = 1;
        for (int i = 0; i < n; i++) {
            answer[i] = prefix;
            prefix = prefix * nums[i];
        }

        int suffix = 1;

        for (int j = n - 1; j >= 0; j--) {
            answer[j] = answer[j] * suffix;
            suffix = suffix * nums[j];
        }

        return answer;
    }
}

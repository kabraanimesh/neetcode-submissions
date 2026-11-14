public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;

        long sum = n * (n+1) / 2;

        foreach (var num in nums) {
            sum -= num;
        }

        return (int)sum;
    }
}

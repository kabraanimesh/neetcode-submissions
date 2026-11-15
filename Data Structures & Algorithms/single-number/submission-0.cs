public class Solution {
    public int SingleNumber(int[] nums) {
        int ans = 0;

        foreach (var n in nums) {
            ans ^= n;
        }
        return ans;
    } 
}

public class Solution {
    public int LongestConsecutive(int[] nums) {
        var numSet = new HashSet<int>(nums);
        int longest = 0;

        foreach (var n in nums) {
            if (!numSet.Contains(n - 1)) {
                int length = 1;
                while (numSet.Contains(n + length)) {
                    length++;
                }
                longest = Math.Max(length, longest);
            }
        }

        return longest;
    }
}

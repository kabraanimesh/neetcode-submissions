public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int n = heights.Length;
        int right = n - 1;
        int max = 0;

        while (left < right) {
            int cap = Math.Min(heights[left], heights[right]);
            max = Math.Max(cap * (right - left), max);
            if (heights[left] <= heights[right]) {
                left++;
            }
            else {
                right--;
            }
        }

        return max;
    }
}

public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;

        for (int i = 0; i < prices.Length; i++) {
            int curr = 0;

            int y = i + 1;

            while (y < prices.Length && prices[y] > prices[i]) {
                curr = Math.Max(prices[y] - prices[i], curr);
                y++;
            }

            max = Math.Max(curr, max);
        }
        return max;
    }
}

public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        for (int i = 0; i < prices.Length; i++) {
            int currProfit = 0;

            int y = i + 1;
            while ( y < prices.Length && prices[y] > prices[i]) {
                currProfit = Math.Max(currProfit, prices[y] - prices[i]);
                y++;
            }

            maxProfit = Math.Max(maxProfit, currProfit);
        }

        return maxProfit;
    }
}

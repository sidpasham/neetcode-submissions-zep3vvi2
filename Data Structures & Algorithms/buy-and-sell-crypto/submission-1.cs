public class Solution {
    public int MaxProfit(int[] prices) {

        int profit = 0;
        int l = 0;
        int r = 1;

        // 3, 4, 5, 16, 1, 9, 5

        while(r < prices.Length) {
            int curProfit = prices[r] - prices[l];
            if(curProfit > profit) {
                profit = curProfit;
            }

            if(prices[l] > prices[r]) {
                l++;
                continue;
            }
            r++;
        }

        return profit;
    }
}

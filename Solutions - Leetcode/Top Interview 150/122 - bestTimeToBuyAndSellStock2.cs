// You are given an integer array prices where prices[i] is the price of a given stock on the ith day.

// On each day, you may decide to buy and/or sell the stock. You can only hold at most one share of the stock at any time. 
// However, you can buy it then immediately sell it on the same day.

// Find and return the maximum profit you can achieve.

public class Solution {

    // Sliding window approach.
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int l = 0;
        int r = 1;

        while(r < prices.Length){
            if(prices[l] < prices[r]){
                int profit = prices[r] - prices[l];
                maxProfit += profit;

                l = r;
            }
            else{
                l = r;
            }
            r++;
        }

        return maxProfit;
    }
}
// You are given an array prices where prices[i] is the price of a given stock on the ith day.

// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

// Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int l = 0; // buy
        int r = 1; // sell

        while(r < prices.Length){
            if(prices[l] < prices[r]){
                int p = prices[r] - prices[l];
                if(p > profit) 
                    profit = p;
            }
            else{
                l = r;
            }
            r++;
        }

        return profit;
    }
}
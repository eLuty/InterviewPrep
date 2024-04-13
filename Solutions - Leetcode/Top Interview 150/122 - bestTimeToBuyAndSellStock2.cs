// You are given an integer array prices where prices[i] is the price of a given stock on the ith day.

// On each day, you may decide to buy and/or sell the stock. You can only hold at most one share of the stock at any time. 
// However, you can buy it then immediately sell it on the same day.

// Find and return the maximum profit you can achieve.

public class Solution {

    // Sliding window approach.
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int l = 0; // left pointer
        int r = 1; // right pointer

        while(r < prices.Length){
            // check if the left element is smaller than the right
            if(prices[l] < prices[r]){

                // left is smaller than the right; calc profit and add it to the max
                int profit = prices[r] - prices[l];
                maxProfit += profit;

                // move the left pointer to the right position
                l = r;
            }
            else{

                // left is larger than the right, move left pointer to the right
                l = r;
            }

            // increment the right pointer
            r++;
        }

        return maxProfit;
    }
}
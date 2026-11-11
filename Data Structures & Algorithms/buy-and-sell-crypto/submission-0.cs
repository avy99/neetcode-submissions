public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int minPrice = prices[0];
        for(int i=1;i<prices.Length; i++){
            int currPrice = prices[i];
            minPrice = Math.Min(minPrice,currPrice);
            profit = Math.Max(currPrice-minPrice, profit);
        }
        return profit;
    }
}

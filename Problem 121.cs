public class Solution {
    public int MaxProfit(int[] prices) {
        int final = 0;
        int low = 999999999;
        foreach(int price in prices)
        { 
            if (price < low) 
                low = price;
            else if (price - low > final) 
                final = price - low;
        }
        return final;
    }
}
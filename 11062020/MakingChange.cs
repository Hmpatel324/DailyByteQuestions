public class Solution {
    public int CoinChange(int[] coins, int amount)
    {
        var dp = new List<int>(Enumerable.Repeat(int.MaxValue,amount + 1));
        // Seed Coin amount 
        dp[0] = 0;
        foreach(var amt in Enumerable.Range(0, amount + 1)){
            foreach(var coin in coins){
                // Check if amt is divisible by some combination of coin
                if(amt - coin >= 0 && dp[amt - coin] < int.MaxValue) dp[amt] = Math.Min(dp[amt], dp[amt - coin] + 1);
            }
        }
        return dp.Last() == int.MaxValue ? -1 : dp.Last();
    }
}
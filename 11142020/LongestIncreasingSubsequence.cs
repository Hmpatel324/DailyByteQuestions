public class Solution {
    public int LengthOfLIS(int[] nums)
    {
        var res = 1;
        // Dp array
        var dp = new List<int>(Enumerable.Repeat(1, nums.Length));
        foreach(var i in Enumerable.Range(0, nums.Length)){
            foreach (var j in Enumerable.Range(0, i))
            {
                // curr value is GREATER than the prev value
                if(nums[i] > nums[j]){
                    // Update DP and res
                    dp[i] = Math.Max(dp[j] + 1, dp[i]);
                    res = Math.Max(res, dp[i]);
                }
            }
        }
        return res;
    }
}
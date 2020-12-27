public class Solution {
    public int LongestCommonSubsequence(string text1, string text2)
    {
        int t1Length = text1.Length, t2Length = text2.Length;
        var dp = new int[t1Length + 1, t2Length + 1];
        foreach (var i in Enumerable.Range(1, t1Length))
        {
            foreach (var j in Enumerable.Range(1, t2Length))
            {
                var maxInherited = (new int[] { dp[i - 1, j - 1], dp[i - 1, j], dp[i, j - 1]}.Max());
                if( i == 0 || j == 0) dp[i,j] = 0;
                else if (text1[i - 1] == text2[j - 1]) dp[i, j] = 1 + dp[i-1, j-1];
                else dp[i, j] = maxInherited;
            }
        }
        return dp[t1Length, t2Length];
    }
}
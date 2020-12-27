public class Solution {
    public int MaxSubArray(int[] nums) {
        //Kadanes DP algo
        int res = nums[0];
        foreach(var i in Enumerable.Range(1,nums.Length-1)){
            nums[i]=Math.Max(nums[i],nums[i-1]+nums[i]); //In place update
            res = Math.Max(nums[i],res); //update res with max of the current value alone or previous plus current
        }
        return res;
    }
}
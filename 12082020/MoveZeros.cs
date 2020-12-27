public class Solution {
    public void MoveZeroes(int[] nums)
    {
        int slow = 0, fast = 0;
        while (fast < nums.Length)
        {
            // Case to flip
            if(nums[slow]==0 && nums[fast]!=0){
                nums[slow] = nums[fast];
                nums[fast] = 0;
                slow += 1;
            }
            // Case: Increment fast to explore forward
            else if (nums[slow] == 0 && nums[fast] == 0)
            {
                fast += 1;
            }
            // Move Forward
            else{
                slow+=1;
                fast = slow;
            }
        }
    }
}
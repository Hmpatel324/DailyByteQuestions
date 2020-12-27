public class Solution {
    public int MissingNumber(int[] nums) {
        var store = new HashSet<int>(Enumerable.Range(0,nums.Length+1));
        foreach(var i in nums){
            store.Remove(i);
        }
        return store.FirstOrDefault();
    }
}
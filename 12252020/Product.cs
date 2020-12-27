public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        // Iterate and detect number of Zeros and associated products
        int zeroCount = 0, product = 1, nonZeroProduct = 1;
        foreach(var i in nums){
            if(i == 0) zeroCount += 1;
            else nonZeroProduct *= i;
            product *= i;
        }
        // Map nums to transformed
        return nums.Select(x => {
            if (x == 0 && zeroCount == 1) return nonZeroProduct;
            else if (x == 0 && zeroCount > 1) return 0;
            else return product/x;
        })
        .ToArray();
    }
}
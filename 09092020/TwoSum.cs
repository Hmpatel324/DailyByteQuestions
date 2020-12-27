bool TwoSum(int[] nums, int k){
	var cache = new HashSet<int>(); // Used for caching integers in nums that have been seen
	foreach(var i in nums){
		if(cache.Contains(k-i)){ // Look up if the difference is contained in the set
			return true;
		}
		cache.Add(i);
	}
	return false; // if difference never found - return false
}


// int[] input;
//  This question is asked by Google.Given an array of integers, return whether or not two numbers sum to a given target, k.
//  Note: you may not sum a number with itself.
// 
//  Ex: Given the following...
//  [1, 3, 8, 2], k = 10, return true (8 + 2)
// input = new int[] {1, 3, 8, 2};
// Console.WriteLine(TwoSum(input, 10));
//  [3, 9, 13, 7], k = 8, return false
// input = new int[] {3, 9, 13, 7};
// Console.WriteLine(TwoSum(input, 8));
//  [4, 2, 6, 5, 2], k = 4, return true(2 + 2)
// input = new int[] {4, 2, 6, 5, 2};
// Console.WriteLine(TwoSum(input, 4));
//  
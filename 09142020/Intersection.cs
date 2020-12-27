int[] NumsIntersection(int[] nums1, int[] nums2){
	return nums1.ToHashSet().Intersect(nums2.ToHashSet()).ToArray();
}



// This question is asked by Google. Given two integer arrays, return their intersection. 
// Note: the intersection is the set of elements that are common to both arrays. 

// Ex: Given the following arrays...
// nums1 = [2, 4, 4, 2], nums2 = [2, 4], return [2, 4]
// var nums1 = new int[] {2, 4, 4, 2};
// var nums2 = new int[] {2, 4};
// Console.WriteLine(NumsIntersection(nums1, nums2));
// nums1 = [1, 2, 3, 3], nums2 = [3, 3], return [3]
// nums1 = new int[] { 1, 2, 3, 3};
// nums2 = new int[] {3, 3};
// Console.WriteLine(NumsIntersection(nums1, nums2));
// nums1 = [2, 4, 6, 8], nums2 = [1, 3, 5, 7], return []
// nums1 = new int[] {2, 4, 6, 8};
// nums2 = new int[] {1, 3, 5, 7};
// Console.WriteLine(NumsIntersection(nums1, nums2));


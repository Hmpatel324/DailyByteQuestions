public class Solution {
    public bool IsMonotonic(int[] A)
	{
		var index = 1;
		// Forward search - monotone small to large
		bool pos = true;
		while (index < A.Length)
		{
			if (A[index - 1] > A[index])
			{
				pos = false;
				break;
			}
			index++;
		}

		// Reverse Search - mono tone large to small
		bool neg = true;
		index = 1;
		while (index < A.Length)
		{
			if (A[index - 1] < A[index])
			{
				neg = false;
				break;
			}
			index++;
		}
		return (pos || neg);
	}
}
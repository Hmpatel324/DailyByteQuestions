public class Solution
{
	public bool LeafSimilar(TreeNode root1, TreeNode root2)
	{
		// Helper method - DFS to get Left to right children 
		List<int> GetLeafs(TreeNode root)
		{
			var res = new List<int>();
			var stack = new Stack<TreeNode>();
			stack.Push(root);
			while (stack.Count > 0)
			{
				var curr = stack.Pop();
				if (curr.left != null) stack.Push(curr.left);
				if (curr.right != null) stack.Push(curr.right);
				if (curr.right == null && curr.left == null) res.Add(curr.val);
			}
			return res;
		}
		// Get Children of both trees
		var t1Leaves = GetLeafs(root1);
		var t2Leaves = GetLeafs(root2);
		// Compare 
		if (t1Leaves.Count != t2Leaves.Count) return false;
		foreach (var i in Enumerable.Range(0, t1Leaves.Count))
		{
			if (t1Leaves[i] != t2Leaves[i]) return false;
		}
		return true;
	}
}
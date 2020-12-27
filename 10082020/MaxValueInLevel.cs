public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
	{
		this.val = val;
		this.left = left;
		this.right = right;
	}
}

public class Solution
{
	public IList<int> LevelOrder(TreeNode root)
	{
		var res = new List<int>();
		var queue = new Queue<List<TreeNode>>();
		if (root != null)
		{
			queue.Enqueue(new List<TreeNode>() { root });
			while (queue.Count > 0)
			{
				var currentLevelNodes = queue.Dequeue();
				var levelValues = new List<int>();
				var nextLevelNodes = new List<TreeNode>();
				foreach (var node in currentLevelNodes)
				{
					levelValues.Add(node.val);
					if (node.left != null) nextLevelNodes.Add(node.left);
					if (node.right != null) nextLevelNodes.Add(node.right);
				}
				res.Add(levelValues.Max());
				if (nextLevelNodes.Count > 0) queue.Enqueue(nextLevelNodes);
			}
		}
		return res;
	}
}
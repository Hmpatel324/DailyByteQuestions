public class Solution
{
	public bool IsValidBST(TreeNode root)
	{
		if (root != null) // Null Check
		{
			// Queue for processing - (Node, MinObserved, MaxObserved)
			var queue = new Queue<(TreeNode, double, double)>();
			queue.Enqueue((root, double.NegativeInfinity, double.PositiveInfinity)); // Seed Data
			while (queue.Count > 0)
			{
				(TreeNode node, double min, double max) curr = queue.Dequeue();
				if (!(curr.node.val < curr.max && curr.node.val > curr.min)) return false; // if curr node violates BST property
				if (curr.node.left != null) queue.Enqueue((curr.node.left, curr.min, curr.node.val)); // Left then enqueue with updated max
				if (curr.node.right != null) queue.Enqueue((curr.node.right, curr.node.val, curr.max)); // right then enqueue with updated min
			}
		}
		return true;
	}
}
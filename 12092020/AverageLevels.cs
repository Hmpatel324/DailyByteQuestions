public class Solution
{
	public IList<double> AverageOfLevels(TreeNode root)
	{
		var res = new List<double>();
		var queue = new Queue<List<TreeNode>>(); // Queue for processing
		queue.Enqueue(new List<TreeNode>() { root }); // Seed Data
		while (queue.Count != 0)
		{
			var currLevel = queue.Dequeue(); // Current Level nodes
			var currLevelSum = 0.0;
			var nextLevel = new List<TreeNode>();
			foreach (var node in currLevel)
			{
				currLevelSum += node.val; // Update curr level sum
				if (node.left != null) nextLevel.Add(node.left); // IF left child then add
				if (node.right != null) nextLevel.Add(node.right); // IF right child then add
			}
			res.Add((currLevelSum / currLevel.Count)); // Update output
			if (nextLevel.Count != 0) queue.Enqueue(nextLevel);
		}
		return res;
	}
}
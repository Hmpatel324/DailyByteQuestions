public class Node
{
	public int val;
	public IList<Node> children;

	public Node() { }

	public Node(int _val)
	{
		val = _val;
	}

	public Node(int _val, IList<Node> _children)
	{
		val = _val;
		children = _children;
	}
}

public class Solution
{
	public IList<IList<int>> LevelOrder(Node root) {
		var res = new List<IList<int>>();
		var queue = new Queue<List<Node>>();
		if (root != null)
		{
			queue.Enqueue(new List<Node>() { root });
			while (queue.Count > 0)
			{
				var currentLevelNodes = queue.Dequeue();
				var levelValues = new List<int>();
				var nextLevelNodes = new List<Node>();
				foreach (var node in currentLevelNodes)
				{
					levelValues.Add(node.val);
					foreach(var child in node.children){
						nextLevelNodes.Add(child);
					}
				}
				res.Add(levelValues);
				if (nextLevelNodes.Count > 0) queue.Enqueue(nextLevelNodes);
			}
		}
		return res;
	}
}
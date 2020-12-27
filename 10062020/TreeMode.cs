/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
	public int[] FindMode(TreeNode root)
	{
		if(root == null) return new int[0];
		int maxFrequency = 0;
		var countDictionary = new Dictionary<int,int>();
		var queue = new Queue<TreeNode>();
		queue.Enqueue(root);
		while(queue.Count > 0){
			var currNode = queue.Dequeue();
			countDictionary[currNode.val] = countDictionary.ContainsKey(currNode.val) ? countDictionary[currNode.val]+1 : 1;
			maxFrequency = Math.Max(maxFrequency, countDictionary[currNode.val]);

			if (currNode.left != null) queue.Enqueue(currNode.left);
			if (currNode.right != null) queue.Enqueue(currNode.right);
		}
		
		return countDictionary.Where(x => x.Value == maxFrequency).Select(x => x.Key).ToArray();
	}
}
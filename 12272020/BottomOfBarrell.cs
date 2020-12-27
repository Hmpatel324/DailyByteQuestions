public class Solution {
    public int FindBottomLeftValue(TreeNode root)
    {
        var queue = new Queue<List<TreeNode>>();
        int res = -1;
        // Seed Data
        queue.Enqueue(new List<TreeNode> {root});
        while(queue.Count > 0){
            var currLevel = queue.Dequeue();
            // Update res with first value in level
            res = currLevel.First().val;
            // Next level create and enqueue
            var nextLevel = new List<TreeNode>();
            foreach(var node in currLevel){
                if (node.left != null) nextLevel.Add(node.left);
                if (node.right != null) nextLevel.Add(node.right);
            }
            if(nextLevel.Count > 0) queue.Enqueue(nextLevel);
        }
        return res;
    }
}
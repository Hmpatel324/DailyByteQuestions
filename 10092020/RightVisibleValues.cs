public class Solution {
    public IList<int> RightSideView(TreeNode root)
    {
        // Out Ds
        var res = new List<int>();
        if(root==null) return res; // Null Check
        var queue = new Queue<List<TreeNode>>();
        // Seed Data
        queue.Enqueue(new List<TreeNode>() { root });
        while(queue.Count > 0){
            var currLevelTreeNodes = queue.Dequeue();
            // Append Val of first item in curr level - implicitly right to left
            res.Add(currLevelTreeNodes.First().val);
            var nextLevel = new List<TreeNode>();
            // Iterate over current and append to next level list
            foreach (var node in currLevelTreeNodes)
            {
                if (node.right != null) nextLevel.Add(node.right);
                if (node.left != null) nextLevel.Add(node.left);
            }
            // Add next level to quueue IF level if nodes in level exist
            if(nextLevel.Count > 0) queue.Enqueue(nextLevel);
        }
        return res;
    }
}
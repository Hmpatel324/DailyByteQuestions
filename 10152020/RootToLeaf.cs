public class Solution {
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        var res = new List<string>();
        if(root == null) return res;
        var queue = new Queue<(TreeNode, string)>();
        // Seed Data
        queue.Enqueue((root,string.Empty));
        while(queue.Count > 0){
            (TreeNode node, string path) curr = queue.Dequeue();
            // if new link then do not need to pre-fix with "->"
            var updatedPath = string.IsNullOrEmpty(curr.path) ? curr.node.val.ToString() : $"{curr.path}->{curr.node.val}";
            if (curr.node.left == null && curr.node.right == null) res.Add(updatedPath);
            else
            {
                // Enqueue children if exist
                if (curr.node.left != null) queue.Enqueue((curr.node.left, updatedPath));
                if (curr.node.right != null) queue.Enqueue((curr.node.right, updatedPath));
            }
        }
        return res;
    }
}
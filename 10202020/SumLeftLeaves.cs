public class Solution {
    public int SumOfLeftLeaves(TreeNode root)
    {
        var res = 0;
        // Null Check
        if(root == null) return res;
        var queue = new Queue<(bool, TreeNode)>();
        // Seed Data
        queue.Enqueue((false, root));
        while(queue.Count > 0){
            (bool isLeft, TreeNode node) curr = queue.Dequeue();
            // if leaf node and isLeft then add to res
            if(curr.isLeft && curr.node.left == null && curr.node.right == null) res += curr.node.val;
            // Add Children
            if (curr.node.left != null) queue.Enqueue((true, curr.node.left));
            if (curr.node.right != null) queue.Enqueue((false, curr.node.right));
        }
        return res;
    }
}
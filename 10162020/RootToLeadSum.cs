public class Solution {
    public bool HasPathSum(TreeNode root, int sum)
    {
        var queue = new Queue<(TreeNode, int)>();
        // Null check
        if (root != null)
        {
            // Seed Data for Queue
            queue.Enqueue((root, 0));
            while (queue.Count > 0)
            {
                (TreeNode node, int sum) curr = queue.Dequeue();
                var updatedSum = curr.sum + curr.node.val; // Update current sum
                // If children nodes exist - then enqueue
                if (curr.node.left != null) queue.Enqueue((curr.node.left, updatedSum));
                if (curr.node.right != null) queue.Enqueue((curr.node.right, updatedSum));
                // if leaf AND updated sum equals targer sum
                if (curr.node.right == null && curr.node.left == null && updatedSum == sum) return true;
            }
        }
        return false;
    }
}
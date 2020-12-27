public class Solution {
    public IList<int> InorderTraversal(TreeNode root)
    {
        var res = new List<int>();
        // Null Check
        if(root==null) return res;
        // Tracks processed (visited) nodes
        var visited = new HashSet<TreeNode>();
        var stack = new Stack<TreeNode>(); // LIFO
        // Seed Data
        stack.Push(root);
        while(stack.Count > 0){
            var curr = stack.Pop();
            if (!visited.Contains(curr))
            {
                visited.Add(curr);
                if (curr.right != null) stack.Push(curr.right);
                stack.Push(curr);
                if (curr.left != null) stack.Push(curr.left);
            }
            else{
                res.Add(curr.val);
            }
        }
        return res;
    }
}
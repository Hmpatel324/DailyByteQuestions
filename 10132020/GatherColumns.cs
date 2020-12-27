public class Solution {
    public IList<IList<int>> VerticalTraversal(TreeNode root)
    {
        var res = new List<IList<int>>();
        if (root == null) return res;
        var cache = new Dictionary<int, List<int>>();
        var queue = new Queue<(TreeNode, int)>();
        queue.Enqueue((root, 0));
        while (queue.Count > 0)
        {
            (TreeNode node, int x) curr = queue.Dequeue();
            if (!cache.ContainsKey(curr.x)) cache[curr.x] = new List<int>();
            cache[curr.x].Add(curr.node.val);
            if (curr.node.left != null) queue.Enqueue((curr.node.left, curr.x - 1));
            if (curr.node.right != null) queue.Enqueue((curr.node.right, curr.x + 1));
        }
        cache.OrderBy(x => x.Key).Select(x => x.Value).ToList().ForEach(x => res.Add(x));
        return res;
    }
}
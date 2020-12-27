public class Solution {
    public bool IsSymmetric(TreeNode root)
    {
        var queue = new Queue<List<TreeNode>>();
        if (root != null)
        {
            queue.Enqueue(new List<TreeNode>() { root });
            while (queue.Count > 0)
            {
                var levelNodes = queue.Dequeue();
                var levelVals = levelNodes.Select(x => x.val).ToList();
                int lo = 0, hi = levelVals.Count - 1;
                while (lo <= hi)
                {
                    if (levelVals[lo] != levelVals[hi]) return false;
                    lo += 1;
                    hi -= 1;
                }
                var nextLevel = new List<TreeNode>();
                foreach (var node in levelNodes)
                {
                    nextLevel.Add((node.left == null) ? new TreeNode(-1) : node.left);
                    nextLevel.Add((node.right == null) ? new TreeNode(-1) : node.right);
                }
                if (nextLevel.Where(x => x.val != -1).Count() > 0) queue.Enqueue(nextLevel);
            }
        }
        return true;
    }
}
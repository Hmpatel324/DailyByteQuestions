/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public int MaxDepth(Node root){
        var maxDepth = 0;
        // Null check
        if(root!=null){
            var queue = new Queue<(int, Node)>();
            // Seed Data
            queue.Enqueue((1, root));
            while(queue.Count > 0){
                (int depth, Node node) curr = queue.Dequeue();

                // update current depth if max
                maxDepth = Math.Max(maxDepth, curr.depth);

                // add children
                foreach (var i in curr.node.children)
                {
                    queue.Enqueue((curr.depth + 1, i));
                }
            }
        }
        return maxDepth;
    }
}
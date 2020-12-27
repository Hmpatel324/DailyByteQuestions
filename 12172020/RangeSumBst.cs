public class Solution {
    public int RangeSumBST(TreeNode root, int L, int R) {
        var queue = new Queue<TreeNode>();
        var res = 0;
        // null check  
        if(root!=null){
            queue.Enqueue(root);
            while(queue.Count ! =0){
                var currNode = queue.Dequeue();
                // Range Check
                if(currNode.val>=L && currNode.val<=R){
                    res += currNode.val;
                }
                // Left check
                if(currNode.left != null && currNode.val>L){
                    queue.Enqueue(currNode.left);
                }
                // Right Check
                if(currNode.right != null && currNode.val<R){
                    queue.Enqueue(currNode.right);
                }
            }
        }
        return res;
    }
}
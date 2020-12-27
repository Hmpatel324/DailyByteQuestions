public class Solution {
    public int MaxDepth(TreeNode root) {
        var treeNodeQueue = new Queue<(TreeNode,int)>();
        int res = 0;
        if(root!=null){
            treeNodeQueue.Enqueue((root,1));   
        }
        while(treeNodeQueue.Count>0){
            var x = treeNodeQueue.Dequeue();
            TreeNode currNode = x.Item1;
            int currDepth = x.Item2;
            res = Math.Max(res,currDepth);
            if(currNode.left!=null){
                treeNodeQueue.Enqueue((currNode.left,currDepth+1));
            }
            if(currNode.right!=null){
                treeNodeQueue.Enqueue((currNode.right,currDepth+1));
            }
        }
        return res;
    }
}
public class Solution {
    public int ClimbStairs(int n)
    {
        var res = 0;
        var queue = new Queue<int>();
        queue.Enqueue(0);
        while(queue.Count > 0){
            var currStepLevel = queue.Dequeue();
            if(currStepLevel == n) res += 1;
            else if(currStepLevel < n){
                queue.Enqueue(currStepLevel + 1);
                queue.Enqueue(currStepLevel + 2);
            }
        }
        return res;
    }
}
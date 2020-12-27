public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var res = new List<IList<int>>();
        var queue = new Queue<(List<int>,int[], int)>(); // Processing Queue
        queue.Enqueue((new List<int>(), candidates, 0)); // Seed Data
        while(queue.Count != 0){
            (List<int> combination, int[] pool, int sum) curr = queue.Dequeue(); 
            for(var i = 0; i < curr.pool.Length; i++){
                var newCombination = curr.combination.Append(curr.pool[i]); // Create new temp combination
                int newSum = curr.sum + curr.pool[i]; // Update temp sum
                if(newSum == target) res.Add(newCombination.ToList()); // Case equals target
                else if(newSum<target){ // case IF lower than target
                    queue.Enqueue((newCombination.ToList(),curr.pool[i..],newSum)); // pool must be restricted from i to end to avoid duplicates
                }
            }
        }
        return res;
    }
}
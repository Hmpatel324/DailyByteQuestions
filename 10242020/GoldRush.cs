public class Solution {
    public int ProcessCell(int[][] grid, (int x, int y) source, int maxRow, int maxCol){
        int sourceMax = int.MinValue;
        var visited = new HashSet<(int,int)>();
        var queue = new Queue<((int, int), int)>();
        queue.Enqueue(((source.x, source.y), 0));
        while(queue.Count != 0){
            ((int x, int y) point, int gold) curr = queue.Dequeue();
            visited.Add(curr.point);
            var gold = curr.gold + grid[curr.point.x][curr.point.y];
            sourceMax = Math.Max(gold, sourceMax);
            var neighbors = new List<(int, int)>{(curr.point.x + 1, curr.point.y), (curr.point.x - 1, curr.point.y), (curr.point.x, curr.point.y + 1), (curr.point.x, curr.point.y - 1) };
            foreach((int x, int y) n in neighbors){
                if(n.x >= 0 && n.x < maxRow && n.y>=0 && n.y < maxCol && grid[n.x][n.y] != 0 && !visited.Contains((n.x, n.y))){
                    queue.Enqueue((n, gold));
                }
            }
        }
        return sourceMax;
    }

    public int GetMaximumGold(int[][] grid)
    {		
        int res = int.MinValue, maxRow = grid.Count(), maxCol = grid[0].Count();
        foreach(var i in Enumerable.Range(0, maxRow)){
            foreach(var j in Enumerable.Range(0, maxCol)){
                if(grid[i][j] != 0) res = Math.Max(res , ProcessCell(grid, (i,j), maxRow, maxCol));
            }
        }
        return res;
    }
}  
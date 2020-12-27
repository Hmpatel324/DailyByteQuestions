public class Solution {
    public int NumIslands(char[][] grid) {
		// Final output
        int res = 0;
        if (grid.Length > 0) // Null check
        {
            int maxRow = grid.Length, maxCol = grid[0].Length; // Row Col contstaints
            void ProcessIsland(int x, int y)
            {
                var queue = new Queue<(int, int)>(); // Queue for processing
                queue.Enqueue((x, y)); // Seed Data
                grid[x][y] = '0'; // Everytime item added to queue flip from 1 to 0 thereby marking processing
                res += 1; // increment island counter
                while (queue.Count != 0)
                {
                    (int currX, int currY) curr = queue.Dequeue(); // Next to be processed
                    var neighbors = new List<(int x, int y)>(){
                            (curr.currX, curr.currY+1),
                            (curr.currX, curr.currY-1),
                            (curr.currX+1, curr.currY),
                            (curr.currX-1, curr.currY)
                        };
                    foreach (var neighbor in neighbors)
                    {
                        // To Qualify for processing neighbor must 0<= x neighbor < maxX 0<= y neighbor < maxY and grid[x][y]==1
                        if (neighbor.x >= 0 && neighbor.x < maxRow && neighbor.y >= 0 && neighbor.y < maxCol && grid[neighbor.x][neighbor.y] == '1')
                        {
                            grid[neighbor.x][neighbor.y] = '0';
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }
            // Grid driver
            for (int i = 0; i < maxRow; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        ProcessIsland(i, j);
                    }
                }
            }
        }
        return res;
    }
}
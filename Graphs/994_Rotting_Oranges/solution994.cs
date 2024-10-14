using System.Collections.Generic;

public class Solution {
    public int OrangesRotting(int[][] grid) {
        int rows = grid.Length;
        if (rows == 0) return -1;
        
        int cols = grid[0].Length;
        int freshCount = 0;
        Queue<(int, int)> rotten = new Queue<(int, int)>();
        
        for (int r = 0; r < rows; ++r) {
            for (int c = 0; c < cols; ++c) {
                if (grid[r][c] == 2) {
                    rotten.Enqueue((r, c));
                } else if (grid[r][c] == 1) {
                    freshCount++;
                }
            }
        }
        
        int minutesPassed = 0;
        int[][] directions = new int[][] {
            new int[] { 1, 0 },
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 0, -1 }
        };
        
        while (rotten.Count > 0 && freshCount > 0) {
            minutesPassed++;
            int rottenCount = rotten.Count;
            
            for (int i = 0; i < rottenCount; ++i) {
                var (x, y) = rotten.Dequeue();
                
                foreach (var dir in directions) {
                    int xx = x + dir[0];
                    int yy = y + dir[1];
                    
                    if (xx < 0 || xx >= rows || yy < 0 || yy >= cols) continue;
                    if (grid[xx][yy] == 0 || grid[xx][yy] == 2) continue;
                    
                    grid[xx][yy] = 2;
                    freshCount--;
                    rotten.Enqueue((xx, yy));
                }
            }
        }
        
        return freshCount == 0 ? minutesPassed : -1;
    }
}

// Runtime1: 72ms, beats 29.56%
// Memory1: 41.83MB, beats 48.94%

// Runtime2: 67ms, beats 60.96%
// Memory2: 41.98MB, beats 37.62%

// Runtime3: 69ms, beats 48.37%
// Memory3: 41.91MB, beats 37.62%
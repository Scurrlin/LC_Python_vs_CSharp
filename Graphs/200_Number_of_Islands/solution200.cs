public class Solution {
    public int NumIslands(char[][] grid) {
        if (grid.Length == 0) return 0;
        
        int numIslands = 0;
        
        for (int i = 0; i < grid.Length; ++i) {
            for (int j = 0; j < grid[0].Length; ++j) {
                if (grid[i][j] == '1') {
                    numIslands++;
                    Dfs(grid, i, j);
                }
            }
        }
        
        return numIslands;
    }
    
    private void Dfs(char[][] grid, int i, int j) {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] != '1') {
            return;
        }
        
        grid[i][j] = '0';
        
        Dfs(grid, i + 1, j);
        Dfs(grid, i - 1, j);
        Dfs(grid, i, j + 1);
        Dfs(grid, i, j - 1);
    }
}

// Runtime1:
// Memory1:

// Runtime2:
// Memory2:

// Runtime3:
// Memory3:

// Runtime reduced by a factor of 10 to not skew data visualization
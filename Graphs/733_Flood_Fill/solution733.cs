public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        int startColor = image[sr][sc];
        
        if (startColor == color) return image;
        
        FloodFillHelper(image, sr, sc, startColor, color);
        
        return image;
    }
    
    private void FloodFillHelper(int[][] image, int x, int y, int startColor, int color) {
        if (x < 0 || x >= image.Length || y < 0 || y >= image[0].Length) return;
        
        if (image[x][y] != startColor) return;
        
        image[x][y] = color;
        
        FloodFillHelper(image, x - 1, y, startColor, color);
        FloodFillHelper(image, x + 1, y, startColor, color);
        FloodFillHelper(image, x, y + 1, startColor, color);
        FloodFillHelper(image, x, y - 1, startColor, color);
    }
}

// Runtime1: 109ms, beats 83.24%
// Memory1: 49.38MB, beats 17.33%

// Runtime2: 106ms, beats 92.38%
// Memory2: 49.16MB, beats 41.71%

// Runtime3: 103ms, beats 97.14%
// Memory3: 48.92MB, beats 71.43%
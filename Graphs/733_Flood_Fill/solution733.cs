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

// Runtime1:
// Memory1:

// Runtime2:
// Memory2:

// Runtime3:
// Memory3:
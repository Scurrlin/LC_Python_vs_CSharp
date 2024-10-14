using System;
using System.Collections.Generic;

public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right) {
            int area = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(maxArea, area);

            if (height[left] < height[right]) {
                left++;
            } else {
                right--;
            }
        }

        return maxArea;
    }
}

// Runtime1: 245ms, beats 68.04%
// Memory1: 62.13MB, beats 41.44%

// Runtime2: 247ms, beats 60.88%
// Memory2: 62.06MB, beats 54.51%

// Runtime3: 249ms, beats 53.80%
// Memory3: 62.08MB, beats 54.51%

// Runtime reduced by a factor of 10 to not skew data visualization
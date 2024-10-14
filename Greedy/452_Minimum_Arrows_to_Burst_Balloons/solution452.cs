using System;
using System.Collections.Generic;

public class Solution {
    public int FindMinArrowShots(int[][] points) {
        if (points.Length == 0) {
            return 0;
        }

        Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));

        int arrows = 1;
        int end = points[0][1];

        foreach (var point in points) {
            if (point[0] > end) {
                arrows++;
                end = point[1];
            }
        }

        return arrows;
    }
}

// Runtime1: 579ms, beats 59.59%
// Memory1: 80.78MB, beats 79.28%

// Runtime2: 574ms, beats 73.91%
// Memory2: 81.78MB, beats 38.62%

// Runtime3: 568ms, beats 83.89%
// Memory3: 80.96MB, beats 62.66%

// Runtime reduced by a factor of 10 to not skew data visualization
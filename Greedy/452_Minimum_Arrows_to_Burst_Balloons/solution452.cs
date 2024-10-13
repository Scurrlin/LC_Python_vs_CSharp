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

// Runtime1:
// Memory1:

// Runtime2:
// Memory2:

// Runtime3:
// Memory3:

// Runtime reduced by a factor of 10 to not skew data visualization
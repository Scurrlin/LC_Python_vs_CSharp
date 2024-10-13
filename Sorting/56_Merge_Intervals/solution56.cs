using System;
using System.Collections.Generic;

public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> output = new List<int[]> { intervals[0] };

        foreach (var interval in intervals) {
            int start = interval[0];
            int end = interval[1];
            int lastEnd = output[output.Count - 1][1];

            if (start <= lastEnd) {
                output[output.Count - 1][1] = Math.Max(lastEnd, end);
            } else {
                output.Add(interval);
            }
        }

        return output.ToArray();
    }
}

// Runtime1:
// Memory1:

// Runtime2:
// Memory2:

// Runtime3:
// Memory3:
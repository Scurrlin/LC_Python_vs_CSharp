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

// Runtime1: 151ms, beats 66.96%
// Memory1: 55.23MB, beats 88.95%

// Runtime2: 149ms, beats 74.05%
// Memory2: 55.42MB, beats 71.69%

// Runtime3: 152ms, beats 63.18%
// Memory3: 55.51MB, beats 61.64%
using System;
using System.Collections.Generic;

public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> res = new List<int[]>();

        for (int i = 0; i < intervals.Length; ++i) {
            if (newInterval[1] < intervals[i][0]) {
                res.Add(newInterval);
                res.AddRange(intervals[i..]);
                return res.ToArray();
            }
            else if (newInterval[0] > intervals[i][1]) {
                res.Add(intervals[i]);
            }
            else {
                newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            }
        }

        res.Add(newInterval);
        return res.ToArray();
    }
}

// Runtime1: 124ms, beats 60%
// Memory1: 50.32MB, beats 20.69%

// Runtime2: 121ms, beats 74.34%
// Memory2: 50.34MB, beats 20.69%

// Runtime3: 126ms, beats 50.48%
// Memory3: 50.01MB, beats 43.86%
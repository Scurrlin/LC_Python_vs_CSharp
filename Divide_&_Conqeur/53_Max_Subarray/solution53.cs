using System;

public class Solution {
    public int MaxSubArray(int[] nums) {
        int res = nums[0];
        int total = 0;

        foreach (int n in nums) {
            total += n;
            res = Math.Max(res, total);
            if (total < 0) {
                total = 0;
            }
        }
        
        return res;
    }
}

// Runtime1: 279ms, beats 66.86%
// Memory1: 62.72MB, beats 41.32%

// Runtime2: 284ms, beats 46.92%
// Memory2: 60.42MB, beats 86.38%

// Runtime3: 283ms, beats 51.08%
// Memory3: 60.21MB, beats 91.37%

// Runtime reduced by a factor of 10 to not skew data visualization
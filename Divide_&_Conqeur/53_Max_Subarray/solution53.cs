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

// Runtime1:
// Memory1:

// Runtime2:
// Memory2:

// Runtime3:
// Memory3:

// Runtime reduced by a factor of 10 to not skew data visualization
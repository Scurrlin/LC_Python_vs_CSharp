using System;
using System.Linq;

public class Solution {
    public int LengthOfLIS(int[] nums) {
        int[] LIS = new int[nums.Length];
        Array.Fill(LIS, 1);

        for (int i = nums.Length - 1; i >= 0; --i) {
            for (int j = i + 1; j < nums.Length; ++j) {
                if (nums[i] < nums[j]) {
                    LIS[i] = Math.Max(LIS[i], 1 + LIS[j]);
                }
            }
        }
        
        return LIS.Max();
    }
}

// Runtime1:
// Memory1:

// Runtime2:
// Memory2:

// Runtime3:
// Memory3:

// Runtime reduced by a factor of 10 to not skew data visualization
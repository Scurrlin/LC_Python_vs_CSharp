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

// Runtime1: 100ms, beats 69.15%
// Memory1: 42.92MB, beats 14.01%

// Runtime2: 108ms, beats 53.47%
// Memory2: 42.66MB, beats 22.11%

// Runtime3: 104ms, beats 61.31%
// Memory3: 42.78MB, beats 18.64%

// Runtime reduced by a factor of 10 to not skew data visualization
using System;
using System.Collections.Generic;

public class Solution {
    public int[] SortArray(int[] nums) {
        Array.Sort(nums);
        return nums;
    }
}

// Runtime1: 318ms, beats 89.09%
// Memory1: 90.97MB, beats 58.13%

// Runtime2: 314ms, beats 90.42%
// Memory2: 90.72MB, beats 62.36%

// Runtime3: 318ms, beats 89.09%
// Memory3: 90.88MB, beats 60.36%

// Runtime reduced by a factor of 10 to not skew data visualization
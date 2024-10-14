using System;
using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> res = new List<IList<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; ++i) {
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }

            int j = i + 1;
            int k = nums.Length - 1;

            while (j < k) {
                int total = nums[i] + nums[j] + nums[k];

                if (total > 0) {
                    k--;
                } else if (total < 0) {
                    j++;
                } else {
                    res.Add(new List<int> { nums[i], nums[j], nums[k] });
                    j++;

                    while (j < k && nums[j] == nums[j - 1]) {
                        j++;
                    }
                }
            }
        }

        return res;
    }
}

// Runtime1: 175ms, beats 59.99%
// Memory1: 74.89MB, beats 87.11%

// Runtime2: 176ms, beats 57.38%
// Memory2: 75.18MB, beats 61.25%

// Runtime3: 175ms, beats 59.99%
// Memory3: 75.20MB, beats 61.25%

// Runtime reduced by a factor of 10 to not skew data visualization
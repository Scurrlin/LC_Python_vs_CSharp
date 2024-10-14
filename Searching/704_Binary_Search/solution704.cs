public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0, r = nums.Length - 1;

        while (l <= r) {
            int m = l + (r - l) / 2;

            if (nums[m] > target) {
                r = m - 1;
            } else if (nums[m] < target) {
                l = m + 1;
            } else {
                return m;
            }
        }

        return -1;
    }
}

// Runtime1: 126ms, beats 96.64%
// Memory1: 51.72MB, beats 18.59%

// Runtime2: 129ms, beats 92.70%
// Memory2: 51.74MB, beats 18.59%

// Runtime3: 133ms, beats 83.82%
// Memory3: 51.46MB, beats 72.32%
public class Solution {
    public bool CanJump(int[] nums) {
        int goal = nums.Length - 1;
        
        for (int i = nums.Length - 2; i >= 0; --i) {
            if (i + nums[i] >= goal) {
                goal = i;
            }
        }
        
        return goal == 0;
    }
}

// Runtime1: 195ms, beats 89.40%
// Memory1: 62.15MB, beats 22.40%

// Runtime2: 190ms, beats 95.56%
// Memory2: 61.96MB, beats 38.44%

// Runtime3: 197ms, beats 85%
// Memory3: 61.90MB, beats 54.72%

// Runtime reduced by a factor of 10 to not skew data visualization
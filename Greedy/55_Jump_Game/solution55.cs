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

// Runtime1:
// Memory1:

// Runtime2:
// Memory2:

// Runtime3:
// Memory3:

// Runtime reduced by a factor of 10 to not skew data visualization
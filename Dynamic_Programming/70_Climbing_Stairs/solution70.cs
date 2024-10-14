public class Solution {
    public int ClimbStairs(int n) {
        int[] dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 1;

        for (int i = 2; i <= n; ++i) {
            dp[i] = dp[i - 1] + dp[i - 2];
        }
        
        return dp[n];
    }
}

// Runtime1: 28ms, beats 13.14%
// Memory1: 26.79MB, beats 62.42%

// Runtime2: 23ms, beats 46.50%
// Memory2: 26.54MB, beats 89.30%

// Runtime3: 28ms, beats 13.14%
// Memory3: 26.78MB, beats 62.42%
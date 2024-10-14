using System;

public class Solution {
    public int Rob(int[] nums) {
        int rob1 = 0, rob2 = 0;

        foreach (int n in nums) {
            int temp = Math.Max(n + rob1, rob2);
            rob1 = rob2;
            rob2 = temp;
        }
        
        return rob2;
    }
}

// Runtime1: 56ms, beats 69.48%
// Memory1: 40.07MB, beats 47.05%

// Runtime2: 54ms, beats 80.93%
// Memory2: 39.98MB, beats 63.87%

// Runtime3: 55ms, beats 75.77%
// Memory3: 39.85MB, beats 78.38%
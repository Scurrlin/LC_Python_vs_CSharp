public class Solution {
    public int MajorityElement(int[] nums) {
        int res = 0, count = 0;

        foreach (int n in nums) {
            if (count == 0) {
                res = n;
            }
            count += (n == res) ? 1 : -1;
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
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

// Runtime1: 110ms, beats 77.98%
// Memory1: 48.88MB, beats 32.20%

// Runtime2: 108ms, beats 83.85%
// Memory2: 48.69MB, beats 60.06%

// Runtime3: 106ms, beats 89.80%
// Memory3: 48.65MB, beats 60.06%
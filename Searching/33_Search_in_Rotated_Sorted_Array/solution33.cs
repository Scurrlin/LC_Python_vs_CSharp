public class Solution {
    public int Search(int[] nums, int target) {
        int L = 0, R = nums.Length - 1;
        
        while (L <= R) {
            int mid = L + (R - L) / 2;
            
            if (nums[mid] == target) {
                return mid;
            }
            
            if (nums[L] <= nums[mid]) {
                if (target > nums[mid] || target < nums[L]) {
                    L = mid + 1;
                } else {
                    R = mid - 1;
                }
            } 
            
            else {
                if (target < nums[mid] || target > nums[R]) {
                    R = mid - 1;
                } else {
                    L = mid + 1;
                }
            }
        }
        
        return -1;
    }
}

// Runtime1: 59ms, beats 82.78%
// Memory1: 41.32MB, beats 56.41%

// Runtime2: 59ms, beats 82.78%
// Memory2: 41.40MB, beats 56.41%

// Runtime3: 53ms, beats 96.23%
// Memory3: 41.76MB, beats 11.19%
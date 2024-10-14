public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int low = 1, high = n;

        while (low <= high) {
            int mid = low + (high - low) / 2;
            int res = guess(mid);
            
            if (res == 0) {
                return mid;
            } else if (res == -1) {
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }

        return -1;
    }
}

// Runtime1: 18ms, beats 78.17%
// Memory1: 26.67MB, beats 69.85%

// Runtime2: 20ms, beats 63.03%
// Memory2: 26.81MB, beats 32.61%

// Runtime3: 19ms, beats 71.49%
// Memory3: 26.75MB, beats 51.57%
public class Solution {
    public void ReverseString(char[] s) {
        int l = 0, r = s.Length - 1;
        while (l < r) {
            char temp = s[l];
            s[l] = s[r];
            s[r] = temp;
            l++;
            r--;
        }
    }
}

// Runtime1: 226ms, beats 55.32%
// Memory1: 129.44MB, beats 25.13%

// Runtime2: 223ms, beats 63.70%
// Memory2: 129.27MB, beats 64.01%

// Runtime3: 227ms, beats 51.90%
// Memory3: 129.49MB, beats 25.13%

// Runtime reduced by a factor of 10 to not skew data visualization
// Memory reduced by a factor of 10 to not skew data visualization
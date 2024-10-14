using System;
using System.Collections.Generic;

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> charSet = new HashSet<char>();
        int l = 0, res = 0;

        for (int r = 0; r < s.Length; ++r) {
            while (charSet.Contains(s[r])) {
                charSet.Remove(s[l]);
                l++;
            }
            charSet.Add(s[r]);
            res = Math.Max(res, r - l + 1);
        }
        
        return res;
    }
}

// Runtime1: 59ms, beats 59.40%
// Memory1: 42.49MB, beats 67.22%

// Runtime2: 60ms, beats 55.53%
// Memory2: 42.53MB, beats 59.57%

// Runtime3: 57ms, beats 66.39%
// Memory3: 42.64MB, beats 51.54%
using System;
using System.Collections.Generic;

public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        int startIndex = 0;
        Dictionary<char, int> pMap = new Dictionary<char, int>();
        Dictionary<char, int> sMap = new Dictionary<char, int>();
        List<int> res = new List<int>();

        foreach (char c in p) {
            if (pMap.ContainsKey(c)) {
                pMap[c]++;
            } else {
                pMap[c] = 1;
            }
        }

        for (int i = 0; i < s.Length; ++i) {
            if (sMap.ContainsKey(s[i])) {
                sMap[s[i]]++;
            } else {
                sMap[s[i]] = 1;
            }

            if (i >= p.Length - 1) {
                if (AreDictionariesEqual(sMap, pMap)) {
                    res.Add(startIndex);
                }

                if (sMap[s[startIndex]] > 1) {
                    sMap[s[startIndex]]--;
                } else {
                    sMap.Remove(s[startIndex]);
                }

                startIndex++;
            }
        }

        return res;
    }

    private bool AreDictionariesEqual(Dictionary<char, int> sMap, Dictionary<char, int> pMap) {
        if (sMap.Count != pMap.Count) return false;
        
        foreach (var pair in sMap) {
            if (!pMap.ContainsKey(pair.Key) || pMap[pair.Key] != pair.Value) {
                return false;
            }
        }
        
        return true;
    }
}


// Runtime1:
// Memory1:

// Runtime2:
// Memory2:

// Runtime3:
// Memory3:
using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> Permute(IList<int> nums) {
        var res = new List<IList<int>>();
        
        if (nums.Count == 1) {
            return new List<IList<int>> { new List<int>(nums) };
        }
        
        for (int i = 0; i < nums.Count; ++i) {
            var numsCopy = new List<int>(nums);
            int n = numsCopy[i];
            numsCopy.RemoveAt(i);
            
            var perms = Permute(numsCopy);
            
            foreach (var perm in perms) {
                perm.Add(n);
            }
            
            res.AddRange(perms);
        }
        
        return res;
    }
}

// Runtime1: 91ms, beats 93.86%
// Memory1: 47.23MB, beats 13.58%

// Runtime2: 99ms, beats 73.93%
// Memory2: 47.72MB, beats 7.63%

// Runtime3: 100ms, beats 70.47%
// Memory3: 47.64MB, beats 8.32%
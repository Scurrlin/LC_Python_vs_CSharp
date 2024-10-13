using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> Permute(IList<int> nums) {
        var res = new List<IList<int>>();
        
        if (nums.Count == 1) {
            return new List<IList<int>> { new List<int>(nums) };
        }
        
        for (int i = 0; i < nums.Count; ++i) {
            int n = nums[0];
            nums.RemoveAt(0);
            
            var perms = Permute(nums);
            
            foreach (var perm in perms) {
                perm.Add(n);
            }
            
            res.AddRange(perms);
            
            nums.Add(n);
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
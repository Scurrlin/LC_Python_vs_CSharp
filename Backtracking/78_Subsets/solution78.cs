using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var res = new List<IList<int>>();
        var subset = new List<int>();
        
        Dfs(0, nums, subset, res);
        
        return res;
    }
    
    private void Dfs(int i, int[] nums, List<int> subset, IList<IList<int>> res) {
        if (i >= nums.Length) {
            res.Add(new List<int>(subset));
            return;
        }
        
        subset.Add(nums[i]);
        Dfs(i + 1, nums, subset, res);
        
        subset.RemoveAt(subset.Count - 1);
        Dfs(i + 1, nums, subset, res);
    }
}

// Runtime1: 97ms, beats 72.98%%
// Memory1: 45.68MB, beats 80.82%

// Runtime2: 89ms, beats 94.04%
// Memory2: 46.15MB, beats 11.11%

// Runtime3: 89ms, beats 94.04%
// Memory3: 45.82ms, beats 50.18%
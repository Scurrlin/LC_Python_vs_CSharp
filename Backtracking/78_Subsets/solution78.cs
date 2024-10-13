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

// Runtime1:
// Memory1:

// Runtime2:
// Memory2:

// Runtime3:
// Memory3:
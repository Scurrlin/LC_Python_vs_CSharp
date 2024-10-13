using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var result = new List<IList<int>>();
        var currentCombination = new List<int>();
        
        Backtrack(candidates, target, 0, currentCombination, result);
        
        return result;
    }
    
    private void Backtrack(int[] candidates, int target, int startIndex, List<int> currentCombination, IList<IList<int>> result) {
        if (target == 0) {
            result.Add(new List<int>(currentCombination));
            return;
        }
        
        for (int i = startIndex; i < candidates.Length; ++i) {
            if (candidates[i] > target) continue;
            currentCombination.Add(candidates[i]);
            
            Backtrack(candidates, target - candidates[i], i, currentCombination, result);
            
            currentCombination.RemoveAt(currentCombination.Count - 1);
        }
    }
}

// Runtime1:
// Memory1:

// Runtime2:
// Memory2:

// Runtime3:
// Memory3:
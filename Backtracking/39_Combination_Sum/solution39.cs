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

// Runtime1: 101ms, beats 80.57%
// Memory1: 46.67MB, beats 95.02%

// Runtime2: 101ms, beats 80.57%
// Memory2: 47.08MB, beats 54.93%

// Runtime3: 102ms, beats 78.18%
// Memory3: 46.93MB, beats 67.46%
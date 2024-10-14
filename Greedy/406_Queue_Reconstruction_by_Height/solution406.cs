using System;
using System.Collections.Generic;

public class Solution {
    public int[][] ReconstructQueue(int[][] people) {
        Array.Sort(people, (a, b) => {
            return a[0] != b[0] ? b[0] - a[0] : a[1] - b[1];
        });
        
        List<int[]> queue = new List<int[]>();
        
        foreach (var person in people) {
            queue.Insert(person[1], person);
        }
        
        return queue.ToArray();
    }
}

// Runtime1: 129ms, beats 74.42%
// Memory1: 52.12MB, beats 72.09%

// Runtime2: 128ms, beats 76.74%
// Memory2: 52.56MB, beats 39.53%

// Runtime3: 134ms, beats 62.79%
// Memory3: 52.15MB, beats 72.09%
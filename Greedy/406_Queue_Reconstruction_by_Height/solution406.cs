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

// Runtime1:
// Memory1:

// Runtime2:
// Memory2:

// Runtime3:
// Memory3:
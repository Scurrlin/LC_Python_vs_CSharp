using System.Collections.Generic;

public class Solution {
    public bool DivideAndConquer(IList<IList<int>> mat, int min_i, int min_j, int max_i, int max_j, int tar) {
        if (min_i > max_i || min_j > max_j) {
            return false;
        }

        int med_i = (min_i + max_i) / 2;
        int med_j = (min_j + max_j) / 2;

        if (mat[med_i][med_j] == tar) {
            return true;
        }

        if (mat[med_i][med_j] > tar) {
            if (DivideAndConquer(mat, min_i, min_j, max_i, med_j - 1, tar)) {
                return true;
            }
            if (DivideAndConquer(mat, min_i, med_j, med_i - 1, max_j, tar)) {
                return true;
            }
        } else {
            if (DivideAndConquer(mat, med_i + 1, min_j, max_i, max_j, tar)) {
                return true;
            }
            if (DivideAndConquer(mat, min_i, med_j + 1, med_i, max_j, tar)) {
                return true;
            }
        }

        return false;
    }

    public bool SearchMatrix(IList<IList<int>> mat, int tar) {
        return DivideAndConquer(mat, 0, 0, mat.Count - 1, mat[0].Count - 1, tar);
    }
}

// Runtime1: 454ms, beats 16.61%
// Memory1: 65.94MB, beats 19.32%

// Runtime2: 459ms, beats 16.27%
// Memory2: 66.13MB, beats 13.90%

// Runtime3: 447ms, beats 16.61%
// Memory3: 66.19MB, beats 13.90%

// Runtime reduced by a factor of 10 to not skew data visualization
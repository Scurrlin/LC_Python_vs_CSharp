using System;
using System.Collections.Generic;

public class Solution {
    public int[] SortArray(int[] nums) {
        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }

    private void Merge(int[] arr, int L, int M, int R) {
        List<int> left = new List<int>(arr[L..(M + 1)]);
        List<int> right = new List<int>(arr[(M + 1)..(R + 1)]);

        int i = L, j = 0, k = 0;

        while (j < left.Count && k < right.Count) {
            if (left[j] <= right[k]) {
                arr[i++] = left[j++];
            } else {
                arr[i++] = right[k++];
            }
        }

        while (j < left.Count) {
            arr[i++] = left[j++];
        }

        while (k < right.Count) {
            arr[i++] = right[k++];
        }
    }

    private void MergeSort(int[] arr, int l, int r) {
        if (l >= r) {
            return;
        }

        int m = l + (r - l) / 2;

        MergeSort(arr, l, m);
        MergeSort(arr, m + 1, r);

        Merge(arr, l, m, r);
    }
}

// Runtime1:
// Memory1:

// Runtime2:
// Memory2:

// Runtime3:
// Memory3:

// Runtime reduced by a factor of 10 to not skew data visualization
// Memory reduced by a factor of 10 to not skew data visualization
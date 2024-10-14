using System.Collections.Generic;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode() { }
    public TreeNode(int val) { this.val = val; }
    public TreeNode(int val, TreeNode left, TreeNode right) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        Stack<TreeNode> stk = new Stack<TreeNode>();
        TreeNode curr = root;

        while (stk.Count > 0 || curr != null) {
            while (curr != null) {
                stk.Push(curr);
                curr = curr.left;
            }

            curr = stk.Pop();
            k--;
            if (k == 0) {
                return curr.val;
            }

            curr = curr.right;
        }

        return -1;
    }
}

// Runtime1: 80ms, beats 63.63%
// Memory1: 45.64MB, beats 38.76%

// Runtime2: 79ms, beats 69.64%
// Memory2: 46.08MB, beats 9.64%

// Runtime3: 81ms, beats 58.76%
// Memory3: 45.52MB, beats 53.47%
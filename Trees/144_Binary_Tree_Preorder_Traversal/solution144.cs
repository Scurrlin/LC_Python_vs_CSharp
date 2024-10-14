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
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> res = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode cur = root;

        while (cur != null || stack.Count > 0) {
            if (cur != null) {
                res.Add(cur.val);
                stack.Push(cur.right);
                cur = cur.left;
            } else {
                cur = stack.Pop();
            }
        }

        return res;
    }
}

// Runtime1: 95ms, beats 76.34%
// Memory1: 45.30MB, beats 90.59%

// Runtime2: 97ms, beats 68.01%
// Memory2: 45.35MB, beats 90.59%

// Runtime3: 90ms, beats 91.40%
// Memory3: 45.22MB, beats 95.97%
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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> output = new List<int>();
        Inorder(root, output);
        return output;
    }

    private void Inorder(TreeNode root, List<int> output) {
        if (root == null) {
            return;
        }

        Inorder(root.left, output);
        output.Add(root.val);
        Inorder(root.right, output);
    }
}

// Runtime1: 92ms, beats 86.99%
// Memory1: 45.57MB, beats 62.03%

// Runtime2: 94ms, beats 81.05%
// Memory2: 45.68MB, beats 43.46%

// Runtime3: 93ms, beats 83.98%
// Memory3: 45.97MB, beats 10.75%
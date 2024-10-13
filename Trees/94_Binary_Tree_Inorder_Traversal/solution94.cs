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

// Runtime1:
// Memory1:

// Runtime2:
// Memory2:

// Runtime3:
// Memory3:
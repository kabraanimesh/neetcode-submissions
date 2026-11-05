/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    int max = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        MaxDepth(root);
        return max;
    }

    public int MaxDepth(TreeNode root) {
        if (root is null) return 0;

        int left = MaxDepth(root.left);
        int right = MaxDepth(root.right);

        max = Math.Max(max, left + right);

        return 1 + Math.Max(left, right);
    }
}

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
    bool isBalanced = true;
    public bool IsBalanced(TreeNode root) {        
        MaxDepth(root);
        return isBalanced;
    }

    public int MaxDepth(TreeNode root) {
        if (root is null) return 0;

        int left = MaxDepth(root.left);
        int right = MaxDepth(root.right);
        if (Math.Abs(left-right) > 1) {
            isBalanced = false;
        }
        return 1 + Math.Max(left, right);

    }
}

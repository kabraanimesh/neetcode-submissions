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
    public int MaxDepth(TreeNode root) {
        if (root is null) return 0;
        
        Stack<(TreeNode node, int depth)> s = new();

        s.Push((root, 1));

        int max = 0;

        while (s.Any()) {
            var top = s.Pop();
            if (top.node.left is null && top.node.right is null) {
                max = Math.Max(max, top.depth);
            }
            if (top.node.left is not null) {
                s.Push((top.node.left, top.depth + 1));
            }
            if (top.node.right is not null) {
                s.Push((top.node.right, top.depth + 1));
            }
        }
        return max;
    }
}

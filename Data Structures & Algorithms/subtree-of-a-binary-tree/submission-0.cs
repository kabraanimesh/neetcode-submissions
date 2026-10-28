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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (root is null && subRoot is null) return true;

        if (root is not null && subRoot is null) return false;

        Stack<TreeNode> s = new ();
        s.Push(root);

        while (s.Any()) {
            var temp = s.Pop();
            if (isSame(temp, subRoot)) {
                return true;
            }
            if (temp.left != null) {
                s.Push(temp.left);
            }
            if (temp.right != null) {
                s.Push(temp.right);
            }
        }
        return false;

        
    }

    public bool isSame(TreeNode q, TreeNode p) {
        if (p is null && q is null) return true;
        if (p is null || q is null) return false;
        if (p.val != q.val) return false;

        var left = isSame(p.left, q.left);
        var right = isSame(p.right, q.right);

        return left && right;

    }
}

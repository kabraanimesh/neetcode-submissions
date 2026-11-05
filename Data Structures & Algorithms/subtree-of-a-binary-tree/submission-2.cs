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

        Stack<TreeNode> s = new ();
        s.Push(root);

        while(s.Any()) {
            var tmp = s.Pop();

            if (IsSame(tmp, subRoot)) {
                return true;
            }

            if (tmp.left != null) s.Push(tmp.left);
            if (tmp.right != null) s.Push(tmp.right);
        }


        return false;
    }

    public bool IsSame(TreeNode p, TreeNode q) {
        if (p is null && q is null) return true;
        if (p is null || q is null) return false;

        if (p.val != q.val) return false;
        var left = IsSame(p.left, q.left);
        var right = IsSame(p.right, q.right);
        return left && right;
    }
}

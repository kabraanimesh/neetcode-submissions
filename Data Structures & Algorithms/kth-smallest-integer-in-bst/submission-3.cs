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
    public int KthSmallest(TreeNode root, int k) {
        Queue<TreeNode> q = new ();
        if (root is null) return 0;

        q.Enqueue(root);
        var l = new List<int>();
        while(q.Count > 0) {
            var tmp = q.Dequeue();
            l.Add(tmp.val);
            if (tmp.left != null) {
                q.Enqueue(tmp.left);
            }
            if (tmp.right != null) {
                q.Enqueue(tmp.right);
            }
        }

        l.Sort();

        return l[k-1];

    }
}

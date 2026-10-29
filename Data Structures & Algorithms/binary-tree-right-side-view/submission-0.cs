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
    public List<int> RightSideView(TreeNode root) {
        if (root is null) return new List<int>();
        var res = new Dictionary<int, int>();
        Queue<(TreeNode node, int depth)> q = new ();

        q.Enqueue((root, 0));

        while (q.Count > 0) {
            var temp = q.Dequeue();
            res[temp.depth] = temp.node.val;
            if (temp.node.left != null) {
                q.Enqueue((temp.node.left, temp.depth + 1));
            }
            if (temp.node.right != null) {
                q.Enqueue((temp.node.right, temp.depth + 1));
            }            
        }
        return res.Values.ToList();
        
    }
}

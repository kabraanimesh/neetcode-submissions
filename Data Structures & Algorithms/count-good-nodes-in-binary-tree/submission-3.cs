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
    public int GoodNodes(TreeNode root) {
        if (root is null) return 0;
        int rootValue = root.val;
        Queue<(TreeNode node, int max)> q = new ();
        var goodMap = new Dictionary<TreeNode, bool>();

        q.Enqueue((root, root.val));

        while (q.Count > 0) {
            var temp = q.Dequeue();             
            if (temp.node.val >= temp.max) {
                goodMap[temp.node] = true;
            }
            if (temp.node.left != null) {                
                q.Enqueue((temp.node.left, Math.Max(temp.node.left.val, temp.max)));
            }

            if (temp.node.right != null) {
                q.Enqueue((temp.node.right, Math.Max(temp.node.right.val, temp.max)));
            }
        }

        return goodMap.Where(kv => kv.Value).Count();
    }
}

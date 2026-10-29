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
    public List<List<int>> LevelOrder(TreeNode root) {
        if (root is null) return new List<List<int>>();
        var res = new Dictionary<int, List<int>>();

        Queue<(TreeNode node, int depth)> q = new ();

        q.Enqueue((root, 0));

        while (q.Count > 0) {
            var temp = q.Dequeue();
            if (res.ContainsKey(temp.depth)) {
                res[temp.depth].Add(temp.node.val);
            }
            else {
                res[temp.depth] = new List<int>{temp.node.val};
            }

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

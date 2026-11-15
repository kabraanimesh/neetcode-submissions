public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        int n = edges.Length;
        List<List<int>> adj = new();

        for (int i = 0; i <= n; i++) {
            adj.Add(new List<int>());
        }

        foreach (var edge in edges) {
            bool[] vis = new bool[n + 1];
            // If a path already exists between edge[0] and edge[1], this edge creates a cycle
            if (HasPath(adj, edge[0], edge[1], vis)) {
                return edge;
            }
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }

        return new int[0];
    }

    private bool HasPath(List<List<int>> adj, int current, int target, bool[] vis) {
        if (current == target) return true;
        vis[current] = true;

        foreach (var neighbor in adj[current]) {
            if (!vis[neighbor]) {
                if (HasPath(adj, neighbor, target, vis)) {
                    return true;
                }
            }
        }

        return false;
    }
}

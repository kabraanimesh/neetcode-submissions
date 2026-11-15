public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        if (edges.Length != n-1) return false;
        List<List<int>> adjList = new ();
        bool[] vis = new bool[n];

        for (int i = 0; i < n; i++) {
            adjList.Add(new List<int>());
        }

        foreach (var edge in edges) {
            adjList[edge[0]].Add(edge[1]);
            adjList[edge[1]].Add(edge[0]);
        }

        if (cycle(adjList, 0, -1, vis)) {
            return false;
        }

        for (int i = 0; i < n; i++) {
            if (!vis[i]) return false;
        }

        return true;
    }

    private bool cycle(List<List<int>> adjList, int node, int parent, bool[] vis) {
        if (vis[node]) return true;

        vis[node] = true;

        foreach (var child in adjList[node]) {
            if (child != parent) {
                if (cycle(adjList, child, node, vis)) return true;
            }
        }

        return false;
    }

}

public class Solution {
    public int CountComponents(int n, int[][] edges) {
        
        List<List<int>> l = new ();

        for (int i = 0; i < n; i++) {
            l.Add(new List<int>());
        }

        foreach (var edge in edges) {
            l[edge[0]].Add(edge[1]);
            l[edge[1]].Add(edge[0]);
        }

        int ans = 0;

        bool[] vis = new bool[n];

        for (int i = 0; i < n; i++) {
            if (!vis[i]) {
                DFS(i, vis, l);
                ans++;
            }
        }

        return ans;
    }

    private void DFS(int node, bool[] vis, List<List<int>> l) {
        if (vis[node]) return;

        vis[node] = true;
        foreach (var child in l[node]) {
            DFS(child, vis, l);            
        }
    }
}

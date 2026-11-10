public class Solution {
    int[][] dir = new int[][] {
        new int[] {0, 1},
        new int[] {1, 0},
        new int[] {-1, 0},
        new int[] {0, -1}
    };
    int max = 0;
    int currMax = 0;
    public int MaxAreaOfIsland(int[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;
        
        bool[][] vis = new bool[n][];
        for (int i = 0; i < n; i++) {
            vis[i] = new bool[m];
        }

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (grid[i][j] == 1 && !vis[i][j]) {
                    currMax = 0;
                    DFS(i, j, grid, vis);
                    max = Math.Max(currMax, max);                    
                }
            }
        }

        return max;
    }

    public void DFS(int n, int m, int[][] grid, bool[][] vis) {
        if (n < 0 || n > grid.Length - 1) return;
        if (m < 0 || m > grid[0].Length - 1) return;

        if (grid[n][m] == 0 || vis[n][m]) return;

        currMax++;
        vis[n][m] = true;

        for (int i = 0; i < dir.Length; i++) {
            int j = dir[i][0] + n;
            int k = dir[i][1] + m;

            DFS(j, k, grid, vis);
        }

    }
}

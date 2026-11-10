public class Solution {
    int[][] dir = new int[][] {
    new int[] {0, 1},
    new int[] {1, 0},
    new int[] {-1, 0},
    new int[] {0, -1}
};
    public int NumIslands(char[][] grid) {
        int islands = 0;
        int n = grid.Length;
        int m = grid[0].Length;

        bool[][] dp = new bool[n][];
        for (int i = 0; i < n; i++) {
            dp[i] = new bool[m];
        }

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (grid[i][j] == '1' && !dp[i][j]) {
                    islands++;
                    DFS(dp, grid, i, j);
                }
            }
        }
        return islands;
    }

    public void DFS(bool[][] dp, char[][] grid, int n, int m) {
        if (n < 0 || n > grid.Length -1 ) return;
        if (m < 0 || m > grid[0].Length - 1) return;
        if (grid[n][m] == '0' || dp[n][m]) return; 
        dp[n][m] = true;
        
        DFS(dp, grid, n-1, m);
        DFS(dp, grid, n+1, m);
        DFS(dp, grid, n, m-1);
        DFS(dp, grid, n, m+1);
    }    
}

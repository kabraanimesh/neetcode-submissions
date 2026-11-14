public class Solution {
    int[][] dir = new int[][] {
        new int[] {0, 1},
        new int[] {1, 0},
        new int[] {-1, 0},
        new int[] {0, -1}
    };
    int m;
    int n;
    public bool Exist(char[][] board, string word) {
        m = board.Length;
        n = board[0].Length;

        var target = word[0];

        var vis = new bool[m][];

        for (int i = 0; i < m; i++) {
            vis[i] = new bool[n];
        }

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (board[i][j] == target) {
                    if (BackTrack(i, j, 1, board, vis, word)) {
                        return true;
                    }
                }                
            }
        }

        return false;
    }

    public bool BackTrack(int i, int j, int targetIndex, char[][] board, bool[][] vis, string word) {
        if (targetIndex == word.Length) return true;

        var target = word[targetIndex];

        vis[i][j] = true;

        foreach (var d in dir) {
            int p = d[0] + i;
            int q = d[1] + j;

            if (!OOB(p, q) && !vis[p][q] && board[p][q] == target) {
                if (BackTrack(p, q, targetIndex + 1, board, vis, word)) {
                    return true;
                }
                vis[p][q] = false;
            }
        }
        vis[i][j] = false;
        return false;
    }

    public bool OOB(int r, int c) {
        if (r < 0 || c < 0 || r == m || c == n) return true;
        return false;
    }
}

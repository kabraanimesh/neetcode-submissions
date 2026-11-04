public class Solution {
    int[][] dir = new int[][] {
        new int[] { 0, 1 },
        new int[] { 1, 0 },
        new int[] { -1, 0},
        new int[] { 0, -1}
    };
    int m;
    int n;

    public bool Exist(char[][] board, string word) {
        m = board.Length;
        n = board[0].Length;

        char target = word[0];
        bool[][] vis = new bool[m][];
        for (int i = 0; i < m; i++)
        {
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
        char target = word[targetIndex];
        vis[i][j] = true;
        foreach (var d in dir) {
            int r = d[0] + i;
            int c = d[1] + j;

            if (!OutOfBounds(r, c) && !vis[r][c] && board[r][c] == target) {
                if (BackTrack(r, c, targetIndex + 1, board, vis, word)) return true;
                vis[r][c] = false;
            }
        }
        vis[i][j] = false;
        return false;
    }

    public bool OutOfBounds(int i, int j) {
        if (i < 0 || j < 0 || i == m || j == n) return true;
        return false;
    }
}

public class Solution {
    int[][] dir = new int[][]
    {
        new int[] { 0, 1 },
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, -1 }
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
                    if (BackTrack(board, i, j, 1, word, vis)) {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    public bool BackTrack(char[][] board, int i, int j, int targetIndex, string word, bool[][] vis) {
        if (targetIndex == word.Length) return true;
        char target = word[targetIndex];
        vis[i][j] = true;
        foreach (var d in dir) {
            int r = d[0] + i;
            int c = d[1] + j; 
            if (!OOB(r, c) && !vis[r][c] && board[r][c] == target) {
                if (BackTrack(board, r, c, targetIndex + 1, word, vis)) return true;
                vis[r][c] = false;
            }
        }
        vis[i][j] = false;

        return false;
    }

    private bool OOB(int i, int j) { // O(1) quick bounds checking, returns true if out of bounds
        if (i < 0 || j < 0 || i == m || j == n) return true;
        return false;
    }
}

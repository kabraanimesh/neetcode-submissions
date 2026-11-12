public class Solution {
    int[][] dir = new int[][] {
        new int[] {0, 1},
        new int[] {1, 0},
        new int[] {-1, 0},
        new int[] {0, -1},
    };

    public bool OOB(int i, int j, char[][] grid) {
        if (i < 0 || j < 0 || i > grid.Length - 1 || j > grid[0].Length - 1) return true;
        return false;
    }

    public bool isBorder(int i, int j, int n, int m) {
        if (i == 0 || j == 0 || i == n - 1 || j == m - 1) {
            return true;
        }
        return false;
    }

    public void Solve(char[][] board) {
        int n = board.Length;
        int m = board[0].Length;

        for (int i  = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (isBorder(i, j, n, m) && board[i][j] == 'O') {
                    DFS(i, j, n, m, board);
                }
            }
        }
        for (int i  = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (board[i][j] == 'O') {
                    board[i][j] = 'X';
                } else if (board[i][j] == '#') {
                    board[i][j] = 'O';
                }
            }
        }

    }

    public void DFS(int n, int m, int r, int c, char[][] grid) {        
        grid[n][m] = '#';        


        foreach (var d in dir) {
            int j = d[0] + n;
            int k = d[1] + m;
            if (!OOB(j, k, grid) && grid[j][k] == 'O') {

                DFS(j, k, r, c, grid);
            }
        }

    }
}

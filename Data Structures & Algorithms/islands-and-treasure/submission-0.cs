public class Solution {
    int[][] dir = new int[][] {
        new int[]{0,1},
        new int[]{1,0},
        new int[]{-1,0},
        new int[]{0,-1}
    };

    public bool OOB(int i, int j, int[][] grid) {
        if (i < 0 || j < 0 || i > grid.Length -1 || j > grid[0].Length - 1) return true;
        return false;
    }
    public void islandsAndTreasure(int[][] grid) {
        var q = new Queue<(int r, int c)>();

        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == 0) {
                    q.Enqueue((i, j));
                }
            }
        }

        while (q.Count > 0) {
            (int r, int c) = q.Dequeue();

            foreach (var d in dir) {
                int row = d[0] + r;
                int col = d[1] + c;

                if (!OOB(row, col, grid) && grid[row][col] == int.MaxValue) {
                    grid[row][col] = grid[r][c] + 1;

                    q.Enqueue((row, col));
                }
            }
        }
    }
}

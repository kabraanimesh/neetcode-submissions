public class Solution {
    int[][] dir = new int[][] {
        new int[] {0,1},
        new int[] {1,0},
        new int[]{-1,0},
        new int[]{0,-1}
    };
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
                var p = d[0] + r;
                var cc = d[1] + c;

                if (!OOB(p, cc, grid.Length, grid[0].Length) && grid[p][cc] == int.MaxValue) {
                    grid[p][cc] = grid[r][c] + 1;
                    q.Enqueue((p, cc));
                }
            }

        }
    }

    public bool OOB(int r, int c, int m, int n) {
        if (r < 0 || c < 0 || r > m-1 || c > n-1) return true;
        return false;
    }
}

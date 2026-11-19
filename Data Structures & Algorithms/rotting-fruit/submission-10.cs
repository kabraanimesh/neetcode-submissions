public class Solution {
    int[][] dir = new int[][] {
        new int[] {0, 1},
        new int[] {1, 0},
        new int[] {-1, 0},
        new int[] {0, -1}
    };
    public int OrangesRotting(int[][] grid) {
      int fresh = 0;
      int time = 0;
      Queue<(int r, int c)> q = new ();

      for (int i = 0; i < grid.Length; i++) {
        for (int y = 0; y < grid[0].Length; y++) {
            if (grid[i][y] == 1) {
                fresh++;
            }
            else if (grid[i][y] == 2) {
                q.Enqueue((i, y));
            }
        }
      }

      while (q.Count > 0 && fresh > 0) {
        int size = q.Count;
        for (int i = 0; i < size; i++) {
            (int r, int c) = q.Dequeue();

            foreach (var d in dir) {
                int k = d[0] + r;
                int j = d[1] + c;

                if (!OOB(k, j, grid) && grid[k][j] == 1) {
                    grid[k][j] = 2;
                    fresh -= 1;
                    q.Enqueue((k, j));
                }
            }
        }
        time += 1;
      }

      if (fresh == 0) return time;
      return -1;
    }

    public bool OOB(int i, int j, int[][] grid) {
        if (i < 0 || j < 0 || i > grid.Length -1 || j > grid[0].Length-1) return true;
        return false;
    }
}

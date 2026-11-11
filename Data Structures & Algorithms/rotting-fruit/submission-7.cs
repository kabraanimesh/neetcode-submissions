public class Solution {
    int[][] dir = new int[][] {
        new int[]{0,1},
        new int[]{1,0},
        new int[]{-1,0},
        new int[]{0,-1}
    };

    public bool OOB(int i, int j, int[][] grid) {
        if (i < 0 || j < 0 || i > grid.Length - 1 || j > grid[0].Length - 1) return true;
        return false;
    }

    public int OrangesRotting(int[][] grid) {
        var q = new Queue<(int r, int c)>();
        int fresh = 0;
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == 2) {
                    q.Enqueue((i, j));
                }
                else if (grid[i][j] == 1) {
                    fresh += 1;
                }
            }
        }
        int time = 0;
        while(q.Count > 0 && fresh > 0) {
            var size = q.Count;
            for (int m = 0; m < size; m++) {
                (int r, int c) = q.Dequeue();
                foreach (var d in dir) {
                    var j = d[0] + r;
                    var k = d[1] + c;

                    if (!OOB(j, k, grid) && grid[j][k] == 1) {
                        grid[j][k] = 2;
                        fresh -= 1;
                        q.Enqueue((j, k));
                    }
                }
            }            
            time += 1;
        }
        if (fresh == 0) return time;
        return -1;        
    }
}

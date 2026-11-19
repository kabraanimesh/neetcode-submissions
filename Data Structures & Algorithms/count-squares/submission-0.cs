public class CountSquares {
    Dictionary<(int r, int c), int> map = new ();
    public CountSquares() {
        
    }
    
    public void Add(int[] point) {
        if (map.ContainsKey((point[0], point[1]))) {
            map[(point[0], point[1])] += 1;
        }
        else {
            map[(point[0], point[1])] = 1;
        }
    }
    
    public int Count(int[] point) {
        int x = point[0];
        int y = point[1];
        int res = 0;
        foreach (var kv in map) {
            (int r, int c) = kv.Key;
            int count = kv.Value;
            int dx = x-r;
            int dy = y-c;

            if (dx ==0 || dy == 0) {
                continue;
            }
            if (Math.Abs(dx) != Math.Abs(dy)) {
                continue;
            }
            if (map.ContainsKey((x,c)) && map.ContainsKey((r, y))) {
                res += (count * map[(x,c)] * map[(r,y)]);
            }
        }
        return res;
    }
}
 
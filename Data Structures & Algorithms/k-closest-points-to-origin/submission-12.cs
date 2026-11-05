public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        int[][] res = new int[k][];

        PriorityQueue<int[], double> q = new ();

        foreach (var point in points) {
            int x = point[0];
            int y = point[1];

            var dist = Math.Sqrt(Math.Pow(x-0, 2)+ Math.Pow(y-0, 2));
            q.Enqueue(point, dist);
        }

        while (k > 0) {
            res[k-- - 1] = q.Dequeue();
        }
        return res;
    }
}

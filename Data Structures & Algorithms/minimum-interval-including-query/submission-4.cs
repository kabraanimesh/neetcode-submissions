

public class Solution {
    public int[] MinInterval(int[][] intervals, int[] queries) {
        // 1. Sort intervals by start time (in-place for better speed/memory)
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        // 2. Keep original query indices and sort queries ascending
        var sortedQueries = queries
            .Select((val, idx) => (val, idx))
            .OrderBy(q => q.val)
            .ToArray();

        int[] res = new int[queries.Length];
        PriorityQueue<(int end, int size), int> pq = new();
        int i = 0;

        foreach (var (q, originalIdx) in sortedQueries) {
            // Add all intervals that start on or before q
            while (i < intervals.Length && intervals[i][0] <= q) {
                int size = intervals[i][1] - intervals[i][0] + 1;
                pq.Enqueue((intervals[i][1], size), size);
                i++;
            }

            // Remove intervals that ended strictly before q
            while (pq.Count > 0 && q > pq.Peek().end) {
                pq.Dequeue();
            }

            // Peek (don't dequeue) to keep valid intervals for future queries
            res[originalIdx] = pq.Count > 0 ? pq.Peek().size : -1;
        }

        return res;
    }
}

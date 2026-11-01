public class Solution {
    public int LastStoneWeight(int[] stones) {
        if (stones.Count() < 2) {
            return stones[0];
        }
        var q = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        foreach (var stone in stones) {
            q.Enqueue(stone, stone);
        }

        while (q.Count > 1) {
            var diff = q.Dequeue() - q.Dequeue();
            if (Math.Abs(diff) != 0) {
                q.Enqueue(Math.Abs(diff), diff);
            }
        }
        return q.Count > 0 ? q.Dequeue() : 0;
    } 
}

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> q = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

        foreach (var n in  nums) {
            q.Enqueue(n, n);
        }

        while (k > 1) {
            k--;
            q.Dequeue();
        }
        return q.Dequeue();
    }
}

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> pq = new ();

        foreach (var n in nums) {
            pq.Enqueue(n, -n);
        }

        while (k > 1) {
            k--;
            pq.Dequeue();
        }

        return pq.Dequeue();
    }
}

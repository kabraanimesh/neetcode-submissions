public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        Dictionary<char, int> freq = new ();

        foreach (var t in tasks) {
            freq[t] = freq.GetValueOrDefault(t, 0) + 1;
        }

        PriorityQueue<int, int> pq = new ();

        foreach (var f in freq.Values) {
            pq.Enqueue(f, -f);
        }

        Queue<(int count, int readyTime)> cooldown = new();

        int time = 0;

        while (pq.Count > 0 || cooldown.Count > 0) {
            time++;

            if (pq.Count > 0) {
                var count = pq.Dequeue();
                count--;

                if (count > 0) {
                    cooldown.Enqueue((count, time + n));
                }
            }

            if (cooldown.Count > 0
            && cooldown.Peek().readyTime == time) {
                var task = cooldown.Dequeue();
                pq.Enqueue(task.count, -task.count);
            }            
        }
        return time;
    }
}

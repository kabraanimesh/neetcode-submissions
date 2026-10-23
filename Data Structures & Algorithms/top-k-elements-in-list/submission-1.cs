public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var counts = new Dictionary<int, int>();
        foreach (var n in nums) {
            counts[n] = counts.GetValueOrDefault(n, 0) + 1;
        }
        return counts.OrderByDescending(kv => kv.Value)
                     .Take(k)
                     .Select(kv => kv.Key)
                     .ToArray();
    }
}

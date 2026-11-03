public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var res = new List<List<int>>{new()};

        foreach (var num in nums) {
            var size = res.Count;
            for (var i = 0; i < size; i++) {
                res.Add([..res[i], num]);
            }
        }
        return res;
    }
}

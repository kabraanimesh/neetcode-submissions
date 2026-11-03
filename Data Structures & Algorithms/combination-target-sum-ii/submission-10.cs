public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        List<List<int>> res = new ();
        List<int> comb = new ();
        HashSet<int> vis = new ();
        Traverse(0, 0, comb, candidates, target, res, vis);
        return res;
    }

    public void Traverse(
        int index, 
        int sum,
        List<int> comb,
        int[] nums, 
        int target,
        List<List<int>> res,
        HashSet<int> vis
    ) {
        if (sum == target) {
            var toAdd = new List<int>(comb);
            if (!res.Any(x => x.SequenceEqual(toAdd)))
            {
                res.Add(toAdd);
            }
            return;
        }

        if (sum > target || index == nums.Length) {
            return;
        }

        for (int i = index; i < nums.Length; i++) {
            if (i > index && nums[i] == nums[i-1]) continue;
            comb.Add(nums[i]);
            vis.Add(nums[i]);
            Traverse(i+1, sum + nums[i], comb, nums, target, res, vis);
            comb.RemoveAt(comb.Count - 1);
            if (target - nums[i] < 0) break;
        }
    }
}

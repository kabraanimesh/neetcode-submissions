public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> res = new ();

        Traverse(nums, new List<int>(), 0, target, 0, res);
        return res;
        
    }

    public void Traverse(int[] nums, List<int> comb, int index, int target, int sum, List<List<int>> res) {
        if (target == sum) {
            res.Add(new List<int>(comb));
        }

        if (sum > target) return;

        for (int i = index; i < nums.Length; i++) {
            comb.Add(nums[i]);
            Traverse(nums, comb, i, target, nums[i] + sum, res);
            comb.RemoveAt(comb.Count - 1);
        }
    }
}

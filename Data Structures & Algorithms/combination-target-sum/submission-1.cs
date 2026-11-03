public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> res = new ();
        List<int> comb = new ();

        Traverse(0, 0, nums, target, comb, res);

        return res;
    }

    public void Traverse(int index, int currSum, int[] nums, int target, List<int> comb, List<List<int>> res) {
        if (currSum == target) {
            res.Add(new List<int>(comb));
        }

        if (currSum > target) {
            return;
        }

        for (int i = index; i < nums.Length; i++) {
            comb.Add(nums[i]);

            Traverse(i, currSum + nums[i], nums, target, comb, res);

            comb.RemoveAt(comb.Count - 1);
        }
    }
}

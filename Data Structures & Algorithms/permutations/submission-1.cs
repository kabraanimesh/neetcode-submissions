public class Solution {

    public List<List<int>> Permute(int[] nums) {
        List<List<int>> res = new ();
        List<int> comb = new ();

        BackTrack(nums, res, comb);
        return res;
    }

    public void BackTrack(int[] nums, List<List<int>> res, List<int> comb) {
        if (nums.Length == comb.Count()) {
            res.Add(new List<int>(comb));
            return;
        }

        for (int i = 0; i < nums.Length; i++) {
            if (comb.Contains(nums[i])) {
                continue;
            }

            comb.Add(nums[i]);
            BackTrack(nums, res, comb);
            comb.RemoveAt(comb.Count() - 1);
        }
    }
}

public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        List<List<int>> res = new ();
        List<int> comb = new ();
        Array.Sort(nums);
        BackTrack(0, nums, comb, res);
        res.Add(new List<int>());
        return res;
    }

    public void BackTrack(int index, int[] nums, List<int> comb, List<List<int>> res) {
        if (comb.Any()) {
            res.Add(new List<int>(comb));
        }

        for (int i = index; i < nums.Length; i++) {
            if (i > index && nums[i] == nums[i - 1]) continue;
                comb.Add(nums[i]);
                BackTrack(i+1, nums, comb, res);
                comb.RemoveAt(comb.Count() - 1);
        }

    }

}
 
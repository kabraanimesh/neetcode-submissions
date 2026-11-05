public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        List<List<int>> res = new ();

        Array.Sort(candidates);

        List<int> comb = new ();

        Traverse(candidates, target, res, 0, 0, comb);
        return res;
    }

    public void Traverse(int[] candidates,
    int target, 
    List<List<int>> res, int index, int sum, List<int> comb) {
        if (sum == target) {
            res.Add(new List<int>(comb));
            return;
        }

        if (sum > target || index == candidates.Length) {
            return;
        }

        for (int i = index; i < candidates.Length; i++) {
            if (i > index && candidates[i] == candidates[i-1]) continue;
            comb.Add(candidates[i]);
            Traverse(candidates, target, res, i+1, sum + candidates[i], comb);
            comb.RemoveAt(comb.Count - 1);
            if (target - candidates[i] < 0) break;
        }
    }
}

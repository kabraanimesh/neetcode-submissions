public class Solution {
    public List<List<string>> Partition(string s) {
        List<List<string>> res = new ();
        int n = s.Length;
        bool[][] dp = new bool[n][];

        for (var i = 0; i < n; i++) {
            dp[i] = new bool[n];
        }

        BackTrack(res, s, dp, 0, new List<string>());
        return res;
    }

    public void BackTrack(List<List<string>> res, string s, bool[][] dp, int i, List<string> choices) {

        if (i == s.Length) {
            res.Add(new List<string>(choices));
            return;
        }

        for (int j = i; j < s.Length; j++) {
            if (isPalindrome(s, i, j, dp)) {
                choices.Add(s.Substring(i, j - i + 1));
                BackTrack(res, s, dp, j + 1, choices);
                choices.RemoveAt(choices.Count - 1);
            }
        }
    }

    public bool isPalindrome(string s, int i, int j, bool[][] dp) {

        if (i > j) return true;
        if (dp[i][j]) return dp[i][j];

        if (s[i] != s[j]) {
            return dp[i][j] = false;
        }
        dp[i][j] = isPalindrome(s, i + 1, j - 1, dp);
        return dp[i][j];
    }
}

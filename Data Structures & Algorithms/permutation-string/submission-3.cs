public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s2.Length < s1.Length) return false;

        var s1map = new Dictionary<char, int>();
        int n = s1.Length;

        foreach (var s in s1) {
            if (s1map.ContainsKey(s)) {
                s1map[s] += 1;
            }
            else {
                s1map[s] = 1;
            }
        }

        int left = 0;
        while (left < s2.Length - n + 1) {
            int right = left + n - 1;

            if (right < s2.Length) {
                var sub = s2.Substring(left, n);
                var map = new Dictionary<char, int>();

                foreach (var b in sub) {
                    if (map.ContainsKey(b)) {
                        map[b] += 1;
                    }
                    else {
                        map[b] = 1;
                    }
                }
                int matched = 0;
                if (map.Count() == s1map.Count()) {
                    foreach (var kv in map) {
                        if (s1map.ContainsKey(kv.Key) && s1map[kv.Key] == kv.Value) {
                            matched += 1;
                        }
                    }
                }
                if (matched == map.Count) {
                    return true;
                }
            }
            left++;
        }
        return false;
    }
}

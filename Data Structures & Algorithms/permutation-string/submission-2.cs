public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s2.Length < s1.Length) {
            return false;
        }
        int n = s1.Length;
        int left = 0;
        var s1map = new Dictionary<char, int>();

        foreach (var ch in s1) {
            if (s1map.ContainsKey(ch)) {
                s1map[ch] += 1;
            }
            else {
                s1map[ch] = 1;
            }
        }


        while (left < s2.Length - n + 1) {
            int right = left + n - 1;
            if (right < s2.Length) {
                var map = new Dictionary<char, int>();
                var sub = s2.Substring(left, n);
                foreach (var c in sub) {
                    if (map.ContainsKey(c)) {
                        map[c] += 1;
                    }
                    else {
                        map[c] = 1;
                    }
                }

                int matched = 0;

                foreach (var kv in map) {
                    if (s1map.ContainsKey(kv.Key)) {
                        if (s1map[kv.Key] == kv.Value) {
                            matched += 1;
                        }
                    }
                }

                if (matched == map.Count()) {
                    return true;
                }                
            }
            left++;
        }
        return false;
    }
}

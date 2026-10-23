public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        var map = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            var c = s[i];
            if (map.ContainsKey(c)) {
                map[c] = ++map[c];
            }
            else {
                map.Add(c, 1);
            }
        }

        for(int y = 0; y < t.Length; y++) {
            var c = t[y];

            if (map.ContainsKey(c)) {
                map[c] = --map[c];
            }
            else {
                map.Add(c, 1);
            }
        }

        if (map.Any(f => f.Value != 0)) {
            return false;
        }
        return true;
    }
}

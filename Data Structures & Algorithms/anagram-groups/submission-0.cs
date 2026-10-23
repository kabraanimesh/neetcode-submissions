public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Count(); i++) {
            var s = strs[i];
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!map.ContainsKey(key)) {
                map.Add(key, new List<string>{s});
            }
            else {
                map[key].Add(s);
            }
        }
        return map.Values.ToList();
    }
}

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max = 1;
        if (s.Length == 0) {
            return 0;
        }
        int left = 0;
        int right = 0;
                HashSet<char> seenWindowChars = new ();

        for (left = 0; left < s.Length; left++) {

            while (right < s.Length && seenWindowChars.Add(s[right])) {
                right++;
            }
            max = Math.Max(max, seenWindowChars.Count());
            seenWindowChars.Remove(s[left]);
        }

        return max;
        
    }
}

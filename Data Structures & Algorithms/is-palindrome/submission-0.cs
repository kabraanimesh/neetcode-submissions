public class Solution {
    public bool IsPalindrome(string s) {
        char[] arr = s.ToCharArray();
        int j = arr.Length - 1;
        int i = 0;
        while (i <= j) {
            if (!char.IsLetterOrDigit(s[i])) {
                i++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[j])) {
                j--;
                continue;
            }
            if (char.ToLower(s[i++]) != char.ToLower(s[j--])) {
                return false;
            }
            
        }
        return true;
        
    }
}

public class Solution {

    public string Encode(IList<string> strs) {
        if (strs == null || strs.Count == 0) return "";

        StringBuilder sb = new StringBuilder();
        foreach (string s in strs) 
        {
            // Format: [Length] + [#] + [String]
            sb.Append(s.Length).Append('#').Append(s);
        }
        
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        if (string.IsNullOrEmpty(s)) return result;

        int i = 0;
        while (i < s.Length) 
        {
            // Find the delimiter marking the end of the length prefix
            int j = i;
            while (s[j] != '#') 
            {
                j++;
            }

            // Extract the length and parse it to an integer
            int length = int.Parse(s.Substring(i, j - i));
            
            // Move pointer past the '#' character
            i = j + 1;

            // Extract the actual string based on the parsed length
            string str = s.Substring(i, length);
            result.Add(str);

            // Move pointer to the start of the next length prefix
            i += length;
        }

        return result;
   }
}

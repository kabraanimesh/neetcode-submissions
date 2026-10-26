public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        int i = 0;
        st.Push(s[i]);
        i++;
        while (i < s.Length) {
            switch (s[i]) {
                case '{':
                case '[':
                case '(':
                    st.Push(s[i]);
                    break;
                case ')':
                    if (st.Count > 0 && '(' == st.Peek()) {
                        st.Pop();
                    }
                    else {
                        st.Push(s[i]);
                    }
                    break;
                case '}':
                    if (st.Count > 0 && '{' == st.Peek()) {
                        st.Pop();
                    }
                    else {
                        st.Push(s[i]);
                    }
                    break;
                case ']':
                    if (st.Count > 0 && '[' == st.Peek()) {
                        st.Pop();
                    }  
                    else {
                        st.Push(s[i]);
                    }
                    break;
                default:
                    st.Push(s[i]);  
                    break;                
                }
            i++;            
        }
        if (st.Count == 0) {
            return true;
        }
        return false;
    }
}

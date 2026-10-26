public class Solution {
    public int[] DailyTemperatures(int[] temp) {
        Stack<(int value, int index)> st = new ();
        int[] res = new int[temp.Length];
        st.Push((temp[0], 0));
        for (int i = 1; i < temp.Length; i++) {
            if (temp[i] > st.Peek().value) {
                while (st.Count > 0 && temp[i] > st.Peek().value) {
                    var pop = st.Pop(); 
                    res[pop.index] = i - pop.index;
                }
            }
            st.Push((temp[i], i));
        }
        while (st.Count > 0) {
            var p = st.Pop();
            res[p.index] = 0;
        }
        return res;
        
    }
}
 
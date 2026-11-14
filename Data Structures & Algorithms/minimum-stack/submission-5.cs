public class MinStack {
    Stack<(int value, int min)> st;
    public MinStack() {
        st = new Stack<(int value, int min)>();
    }
    
    public void Push(int val) {
        int currentMin = st.Count == 0 ? val : Math.Min(val, st.Peek().min);
        st.Push((val, currentMin));
    }
    
    public void Pop() {
        if (st.Count > 0) {
            st.Pop();            
        }
    }
    
    public int Top() {
        if (st.Count > 0) {
            return st.Peek().value;
        }
        else {
            return 0;
        }
    }
    
    public int GetMin() {
        if (st.Count > 0) {
            return st.Peek().min;
        }
        return 0;
    }
}

public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<string> st = new ();

        foreach (var token in tokens) {
            if (token == "+" || 
            token == "-" || 
            token == "*" || 
            token == "/") {
                var first = int.Parse(st.Pop());
                var second = int.Parse(st.Pop());
                int val = 0;
                switch (token) {
                    case "+":
                        val = first + second;
                        break;
                    case "-":
                        val = second - first;
                        break;
                    case "*":
                        val = first * second;
                        break;
                    case "/":
                        val = second / first;
                        break;
                }    
                st.Push(val.ToString());
            }
            else {
                st.Push(token);
            }
        }

        return int.Parse(st.Pop());
    }
}
 
public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<(int val, int index)> s = new ();

        s.Push((temperatures[0], 0));

        int n = temperatures.Length;

        int[] res = new int[n];

        for (int i = 1; i < n; i++) {
            if (temperatures[i] > s.Peek().val) {
                while (s.Count > 0 && temperatures[i] > s.Peek().val) {
                    var pop = s.Pop();
                    res[pop.index] = i - pop.index;
                }
            }
            s.Push((temperatures[i], i));
        }

        while (s.Count > 0) {
            var p = s.Pop();
            res[p.index] = 0;
        }
        return res;
    }
}

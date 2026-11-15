public class Solution {
    public bool IsHappy(int n) {
        var set = new HashSet<int>();
        
        while (true) {
            int r = sum(n.ToString().ToCharArray());
            if (r == 1) {
                return true;
            }
            else if (set.Contains(r)) {
                return false;
            }
            else {
                set.Add(r);
                n = r;
            }
        }


    }

    public int sum(char[] arr){
        int sum = 0;

        foreach (var n in arr) {
            int d = n - '0';
            sum = sum + (int)Math.Pow(d, 2);
        }
        return sum;
    }
}

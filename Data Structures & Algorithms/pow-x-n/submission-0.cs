public class Solution {
    public double MyPow(double x, int n) {
        if (n == 0) return 1;
        if (n == 1) return x;

        if (n == -1) return 1.0/x;

        var res = MyPow(x, n / 2);

        res *= res;
        var odd = n%2;
        if (odd == 1) res *= x;
        if (odd == -1) res /= x;
        return res;
    }
}

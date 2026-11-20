public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
        if (matrix.Length ==0  || matrix[0].Length == 0) return new List<int>();

        List<int> res = new ();
        int top = 0;
        int left = 0;
        int right = matrix[0].Length - 1;
        int bottom = matrix.Length - 1;

        while (left <= right && top <= bottom) {
            for (int i = left; i <= right; i++) {
                res.Add(matrix[top][i]);
            }
            top++;

            for (int i = top; i <= bottom; i++) {
                res.Add(matrix[i][right]);
            }
            right--;

            if (top <= bottom) {
                for (int j = right; j >= left; j--) {
                    res.Add(matrix[bottom][j]);
                }
                bottom--;
            }

            if (left <= right) {
                for (int i = bottom; i >= top; i--) {
                    res.Add(matrix[i][left]);
                }
                left++;
            }
        }
        return res;
    }
}

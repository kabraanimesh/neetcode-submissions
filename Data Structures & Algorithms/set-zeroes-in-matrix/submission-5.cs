public class Solution {
    public void SetZeroes(int[][] matrix) {
        int[] top = new int[matrix[0].Length];
        for (int u = 0; u < top.Length; u++) {
            top[u] = 1;
        }

        for (int i = 0; i < matrix.Length; i++) {
            for (int j = 0; j < matrix[0].Length; j++) {
                if (matrix[i][j] == 0) {
                    matrix[i][0] = 0;
                    top[j] = 0;
                }
            }
        }

        // row
        for (int row = 0; row < matrix.Length; row++) {
            if (matrix[row][0] == 0) {
                for (int col = 1; col < matrix[0].Length; col++) {
                    matrix[row][col] = 0;
                }
            }
        }

        // col
        for (int col = 0; col < matrix[0].Length; col++) {
            if (top[col] == 0) {
                for (int row = 0; row < matrix.Length; row++) {
                    matrix[row][col] = 0;
                }
            }
        }
    }
}

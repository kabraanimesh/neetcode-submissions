public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        int board_rows = 9; int board_cols = 9;
        var colDicts = new Dictionary<char, int>[9];
        var boxDicts = new Dictionary<char, int>[9];
        Dictionary<char, int> dict_rows = new ();
        for (int k = 0; k < 9; k++) {
            boxDicts[k] = new Dictionary<char, int>();
            colDicts[k] = new Dictionary<char, int>();
        }
        for (int i = 0; i < board_rows; i++) {
            if (i>0) {
                dict_rows.Clear();
            }
            for (int j = 0; j < board_cols; j++) {
                if (board[i][j] == '.') {continue;} 
                int boxindex = (i / 3) * 3 + (j / 3);

                // rows
                if (!dict_rows.ContainsKey(board[i][j])) {
                    dict_rows[board[i][j]] = 0;
                }
                dict_rows[board[i][j]]++;
                if (dict_rows[board[i][j]] > 1) {
                    return false;
                }

                //cols
                if (!colDicts[j].ContainsKey(board[i][j])) {
                    colDicts[j][board[i][j]] = 0;
                }
                colDicts[j][board[i][j]]++;
                if (colDicts[j][board[i][j]] > 1) {
                    return false;
                }
                // matrixes 3x3
                if (!boxDicts[boxindex].ContainsKey(board[i][j])){
                    boxDicts[boxindex][board[i][j]] = 0;
                }
                boxDicts[boxindex][board[i][j]]++;
                if (boxDicts[boxindex][board[i][j]] > 1){
                    return false;
                }

            }
        }
        return true;
    }
}

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, HashSet<char>> cols = new ();
        Dictionary<int, HashSet<char>> rows = new ();
        Dictionary<int, HashSet<char>> square = new ();
        
        for(int r=0; r<9; r++){
            for(int c=0; c<9; c++){
                char cell = board[r][c];
                if(cell == '.') continue;

                if(rows.TryGetValue(r, out var rowset) && rowset.Contains(cell) ||
                    cols.TryGetValue(c, out var colset) && colset.Contains(cell) ||
                    square.TryGetValue((r/3)*3 + c/3, out var squareset) && squareset.Contains(cell) ){
                    return false;
                }

                cols.TryAdd(c,new HashSet<char>());
                rows.TryAdd(r,new HashSet<char>());
                square.TryAdd((r/3)*3 + c/3,new HashSet<char>());
                cols[c].Add(cell);
                rows[r].Add(cell);
                square[(r/3)*3 + c/3].Add(cell);


            }
        }
        return true;
    }
}

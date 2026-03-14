namespace Backtracking
{
    // Leetcode : 51 - N-Queens
    // Approach : Backtracking
    // Time Complexity : O(n!)
    // Space Complexity : O(n^2)
    // Type: Hard
    public class NQueens
    {
        HashSet<int> cols = [];
        HashSet<int> leftDiagonal = [];
        HashSet<int> rightDiagonal = [];
        List<IList<string>> result = [];
        public bool IsUnderAttack(int r, int c)
        {
            return cols.Contains(c) || leftDiagonal.Contains(r - c)
                     || rightDiagonal.Contains(r + c);
        }
        public void dfs(char[,] board, int r, int n)
        {
            if (r == n)
            {
                List<string> strings = [];
                for (int i = 0; i < n; i++)
                {
                    string s = "";
                    for (int j = 0; j < n; j++)
                    {
                        s += board[i, j];
                    }
                    strings.Add(new String(s));
                }
                result.Add(strings);
                return;
            }
            // iterate at column level
            for (int i = 0; i < n; i++)
            {
                if (!IsUnderAttack(r, i))
                {
                    board[r, i] = 'Q';
                    cols.Add(i);
                    leftDiagonal.Add(r - i);
                    rightDiagonal.Add(r + i);
                    dfs(board, r + 1, n);
                    board[r, i] = '.';
                    cols.Remove(i);
                    leftDiagonal.Remove(r - i);
                    rightDiagonal.Remove(r + i);
                }
            }
            return;
        }
        public IList<IList<string>> SolveNQueens(int n)
        {
            char[,] board = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = '.';
                }
            }
            dfs(board, 0, n);
            return result;
        }
    }
}

namespace Backtracking
{
    // Easiest variation of N-Queens problem imo
    // Leetcode : 52 - N-Queens II
    // Approach : Backtracking
    // Time Complexity : O(n!)
    // Space Complexity : O(n)
    // Type: Hard
    public class NQueensII
    {
        // Using HashSet to keep track of occupied columns and diagonals
        HashSet<int> cols = [];
        HashSet<int> leftDiagonal = [];
        HashSet<int> rightDiagonal = [];
        // Total count of valid board configurations
        int totalCount = 0;
        public bool IsUnderAttack(int r, int c)
        {
            // Column check - Each queen occupies a unique column
            // Left diagonal check - Every diagonal running from top-left to bottom-right has a constant value of (r - c)
            // Right diagonal check - Every diagonal running from top-right to bottom-left has a constant value of (r + c)
            return cols.Contains(c) || leftDiagonal.Contains(r - c)
                     || rightDiagonal.Contains(r + c);
        }
        public void dfs(char[,] board, int r, int n)
        {
            // Base case: If we have successfully placed queens in all rows
            if (r == n)
            {
                totalCount += 1;
                return;
            }
            // iterate at column level
            for (int i = 0; i < n; i++)
            {
                // If the current cell is not under attack, place a queen there
                if (!IsUnderAttack(r, i))
                {
                    // Place the queen
                    board[r, i] = 'Q';
                    // Mark the column and diagonals as occupied
                    cols.Add(i);
                    leftDiagonal.Add(r - i);
                    rightDiagonal.Add(r + i);
                    // Recurse to the next row
                    dfs(board, r + 1, n);
                    // Backtrack: Remove the queen and mark the column and diagonals as unoccupied
                    board[r, i] = '.';
                    cols.Remove(i);
                    leftDiagonal.Remove(r - i);
                    rightDiagonal.Remove(r + i);
                }
            }
            return;
        }
        public int TotalNQueens(int n)
        {
            // Initialize the board with empty cells
            char[,] board = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = '.';
                }
            }
            // Start the backtracking process from the first row
            dfs(board, 0, n);
            return totalCount;
        }
    }
}

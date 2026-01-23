namespace Arrays
{
    // Leetcode : 36 - Valid Sudoku
    // Approach : HashSet
    // Time Complexity : O(9^2) -> O(1)
    // Space Complexity : O(9^2) -> O(1)
    // Type: Medium
    internal class ValidSudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {

            // check rows
            for (int i = 0; i < 9; i++)
            {
                HashSet<char> set = [];
                for (int j = 0; j < 9; j++)
                {
                    if (set.Contains(board[i][j]))
                    {
                        return false;
                    }
                    if (board[i][j] != '.')
                    {
                        set.Add(board[i][j]);
                    }
                }
            }

            // check columns
            for (int i = 0; i < 9; i++)
            {
                HashSet<char> set = [];
                for (int j = 0; j < 9; j++)
                {
                    if (set.Contains(board[j][i]))
                    {
                        return false;
                    }
                    if (board[j][i] != '.')
                    {
                        set.Add(board[j][i]);
                    }
                }
            }

            // check submatrix
            for (int square = 0; square < 9; square++)
            {
                HashSet<char> set = [];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int rowIndex = (square / 3) * 3 + i;
                        int colIndex = (square % 3) * 3 + j;
                        if (set.Contains(board[rowIndex][colIndex]))
                        {
                            return false;
                        }
                        if (board[rowIndex][colIndex] != '.')
                        {
                            set.Add(board[rowIndex][colIndex]);
                        }
                    }
                }

            }

            return true;
        }
    }
}

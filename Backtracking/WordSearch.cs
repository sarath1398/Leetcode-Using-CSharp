namespace Backtracking
{
    public class WordSearch
    {
        // Leetcode : 79 - Word Search
        // Approach : Backtracking
        // Time Complexity : O(n * m * 4 ^ (n * m))
        // Space Complexity : O(n * m)
        // Type: Medium
        public bool Exist(char[][] board, string word)
        {
            // Base case
            if (board == null || board.Length == 0)
                return false;
            // Get the dimensions of the board
            int N = board.Length;
            int M = board[0].Length;
            // Create a 2D array to keep track of visited cells
            bool[,] used = new bool[N, M];
            // Get the length of the word
            int wLength = word.Length;

            // Helper function to perform DFS
            bool DFS(int N, int M, char[][] board, bool[,] used, int i,
                int wLength, int r, int c)
            {
                // Base case
                if (i == wLength)
                {
                    return true;
                }
                // Base case
                if (r < 0 || c < 0 || r > N - 1 || c > M - 1 || used[r, c] == true ||
                    board[r][c] != word[i])
                {
                    return false;
                }
                // Mark the cell as visited
                used[r, c] = true;
                // Explore all four possible directions
                bool left = DFS(N, M, board, used, i + 1, wLength, r, c - 1);
                bool right = DFS(N, M, board, used, i + 1, wLength, r, c + 1);
                bool down = DFS(N, M, board, used, i + 1, wLength, r - 1, c);
                bool top = DFS(N, M, board, used, i + 1, wLength, r + 1, c);
                // Backtrack
                used[r, c] = false;
                // Return true if any of the four directions return true
                return left || right || down || top;
            }
            // Iterate over the board
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    // Call the helper function
                    bool result = DFS(N, M, board, used, 0, wLength, i, j);
                    // If the helper function returns true, return true
                    if (result)
                    {
                        return true;
                    }
                }
            }
            // If no path is found, return false
            return false;
        }
    }
}

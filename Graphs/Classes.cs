namespace Graphs;

internal class Classes
{
    // Leetcode - 463 - Island Perimeter
    // Approach : DFS
    // Time Complexity : O(m*n)
    // Space Complexity : O(m*n)
    // Type: Easy
    public class IslandPerimeterLC463
    {
        // DFS
        public int IslandPerimeter(int[][] grid)
        {
            // Get the dimensions of the grid
            int rows = grid.Length;
            int cols = grid[0].Length;
            // Create a set to store the visited cells
            HashSet<(int, int)> path = new();

            // DFS function
            int DFS(int i, int j)
            {
                // If the cell is out of bounds or is water, return 1
                if (i < 0 || i >= rows || j < 0 || j >= cols || grid[i][j] == 0)
                {
                    return 1;
                }
                // If the cell has been visited, return 0
                if (path.Contains((i, j)))
                {
                    return 0;
                }
                // Add the cell to the path
                path.Add((i, j));
                // Return the sum of the DFS of the four neighbors
                return DFS(i - 1, j) + DFS(i + 1, j) + DFS(i, j - 1) + DFS(i, j + 1);
            }

            // Iterate through the grid
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // If the cell is land, start DFS
                    if (grid[i][j] == 1)
                    {
                        return DFS(i, j);
                    }
                }
            }

            // If no land is found, return 0
            return 0;
        }
    }
}

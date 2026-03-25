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

    // Leetcode - 997 - Find the Town Judge
    // Approach : Array
    // Time Complexity : O(n)
    // Space Complexity : O(n)
    // Type: Easy
    public class FindTheTownJudgeLC997
    {
        public int FindJudge(int n, int[][] trust) {
            // int[] incoming = new int[n + 1];
            // int[] outgoing = new int[n + 1];

            // Trust Factor = incoming - outgoing
            int[] trustFactor = new int[n + 1];
            int len = trust.Length;
            for(int i = 0; i < len; i++)
            {
                // from -> to
                int from = trust[i][0];
                int to = trust[i][1];

                // incoming[to]++;
                // outgoing[from]--;
                // Increase trust factor for the person who is trusted
                trustFactor[to]++;
                // Decrease trust factor for the person who trusts
                trustFactor[from]--;
            }
            for(int i = 1; i < n + 1; i++)
            {
                // If trust factor is n - 1, then the person is the judge
                if(trustFactor[i] == n - 1)
                    return i;
            }
            // If no judge is found, return -1
            return -1;
        }
    }
}

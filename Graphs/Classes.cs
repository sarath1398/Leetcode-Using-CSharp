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
    
    // Leetcode - 200 - Number of Islands
    // Approach : BFS
    // Time Complexity : O(m*n)
    // Space Complexity : O(m*n)
    // Type: Medium
    public class NumberOfIslandsLC200
    {
        public int NumIslands(char[][] grid) {
            // HashSet<(int,int)> set = new();
            // Queue for BFS
            Queue<(int,int)> queue = new();

            // Get the dimensions of the grid
            int n = grid.Length;
            int m = grid[0].Length;
            int count = 0;

            // Helper function to check if a cell is valid
            bool IsValid(int i, int j)
            {
                if(i < 0 || i >= n || j < 0 || j >= m || grid[i][j] == '0')
                // || set.Contains((i,j))) 
                    return false;
                return true;
            }

            void BFS()
            {
                // While there are cells in the queue
                while(queue.Count > 0)
                {
                    // Dequeue the cell
                    (int r, int c) = queue.Dequeue();
                    // Check the four neighbors
                    if(IsValid(r - 1, c))
                    {
                        queue.Enqueue((r-1,c));
                        // Mark as visited
                        grid[r-1][c] = '0';
                    }
                    if(IsValid(r + 1, c))
                    {
                        queue.Enqueue((r + 1,c));
                        // Mark as visited
                        grid[r+1][c] = '0';
                    }
                    if(IsValid(r, c - 1))
                    {
                        queue.Enqueue((r,c - 1));
                        // Mark as visited
                        grid[r][c-1] = '0';
                    }
                    if(IsValid(r, c + 1))
                    {
                        queue.Enqueue((r,c + 1));
                        // Mark as visited
                        grid[r][c + 1] = '0';
                    }
                }
            }

            // Iterate through the grid
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    // If the cell is land, start BFS
                    if(IsValid(i,j))
                    {
                        queue.Enqueue((i,j));
                        // Mark as visited
                        grid[i][j] = '0';
                        // Start BFS
                        BFS();
                        // Increment the count
                        count++;
                    }   
                }
            }

            return count;
        }
    }

    // Leetcode - 695 - Max Area of Island
    // Approach : BFS
    // Time Complexity : O(m*n)
    // Space Complexity : O(m*n)
    // Type: Medium
    public class MaxAreaOfIslandLC695
    {
        public int MaxAreaOfIsland(int[][] grid) {
            // Queue for BFS
            Queue<(int,int)> queue = new();

            // Get the dimensions of the grid
            int n = grid.Length;
            int m = grid[0].Length;
            int count = 0;

            // Helper function to check if a cell is valid
            bool IsValid(int i, int j)
            {
                if(i < 0 || i >= n || j < 0 || j >= m || grid[i][j] == 0)
                    return false;
                return true;
            }

            // Helper function to perform BFS
            int BFS()
            {
                int count = 0;
                // While there are cells in the queue
                while(queue.Count > 0)
                {
                    // Dequeue the cell
                    (int r, int c) = queue.Dequeue();
                    // Check the four neighbors
                    if(IsValid(r - 1, c))
                    {
                        // Enqueue the neighbor
                        queue.Enqueue((r-1,c));
                        // Mark as visited
                        grid[r-1][c] = 0;
                        // Increment the count
                        count++;
                    }
                    if(IsValid(r + 1, c))
                    {
                        // Enqueue the neighbor
                        queue.Enqueue((r + 1,c));
                        // Mark as visited
                        grid[r+1][c] = 0;
                        // Increment the count
                        count++;
                    }
                    if(IsValid(r, c - 1))
                    {
                        // Enqueue the neighbor
                        queue.Enqueue((r,c - 1));
                        // Mark as visited
                        grid[r][c-1] = 0;
                        // Increment the count
                        count++;
                    }
                    if(IsValid(r, c + 1))
                    {
                        // Enqueue the neighbor
                        queue.Enqueue((r,c + 1));
                        // Mark as visited
                        grid[r][c + 1] = 0;
                        // Increment the count
                        count++;
                    }
                }
                return count;
            }

            // Iterate through the grid
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    // If the cell is land, start BFS
                    if(IsValid(i,j))
                    {
                        // Enqueue the cell
                        queue.Enqueue((i,j));
                        // Mark as visited
                        grid[i][j] = 0;
                        // Update the maximum area - Include the current cell in grid also
                        count = Math.Max(count,1 + BFS());
                    }   
                }
            }

            // Return the maximum area
            return count;
        }
    }
    
    
    public class Node {
        public int val;
        public IList<Node> neighbors;

        public Node() {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val) {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors) {
            val = _val;
            neighbors = _neighbors;
        }
    }

    // Leetcode - 133 - Clone Graph
    // Approach : DFS
    // Time Complexity : O(V+E)
    // Space Complexity : O(V)
    // Type: Medium
    public class CloneGraphLC133
    {
        // Helper function to perform DFS
        public Node DFS(Node curr,Dictionary<int,Node> map)
        {
            // Return null if the current node is null
            if(curr == null)
                return null;

            // Get the value of the current node
            int val = curr.val;

            // If the node is already visited, return the cloned node
            if(map.ContainsKey(val))
            {
                return map[val];
            }

            // Create a new node
            Node newNode = new Node(val);
            // Add the new node to the map
            map.Add(val,newNode);
            // Iterate through the neighbors of the current node
            foreach(Node neighbour in curr.neighbors)
            {
                // Recursively call DFS for each neighbor
                newNode.neighbors.Add(DFS(neighbour,map));
            }
            // Return the cloned node
            return newNode;
        }
        public Node CloneGraph(Node node) {
            // Create a map to store the cloned nodes
            Dictionary<int,Node> map = new();
            // Call the DFS function to clone the graph
            return DFS(node,map);
        }
    }

    // Leetcode 286 - Walls and Gates
    // Approach : Multi-Source BFS
    // Time Complexity : O(m*n)
    // Space Complexity : O(m*n)
    // Type: Medium
    public class WallsAndGatesLC286
    {
        public void WallsAndGates(int[][] grid) {
            // Get the dimensions of the grid
            int n = grid.Length;
            int m = grid[0].Length;
            // Create a queue for BFS
            Queue<(int r, int c)> queue = new();

            // Helper function to check if a cell is valid
            bool IsValid(int i,int j)
            {
                if(i < 0 || i >= n || j < 0 || j>= m)
                    return false;
                return true;
            }
            // Add all the gates to the queue
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if(grid[i][j] == 0)
                    {
                        queue.Enqueue((i,j));
                    }
                }
            }
            // Directions for moving in the grid
            int[][] directions = [ 
                    [1,0],
                    [0,1],
                    [-1,0],
                    [0,-1]
                ];
            // Perform BFS
            while(queue.Count > 0)
            {
                // Dequeue the cell
                (int r, int c) = queue.Dequeue();
                // Check the four neighbors
                foreach(var direction in directions)
                {
                    int i = r + direction[0];
                    int j = c + direction[1];

                    // Check if the neighbor is valid
                    if(!IsValid(i,j))
                        continue;
                    // Check if the neighbor is a gate
                    if(grid[i][j] != int.MaxValue)
                        continue;
                    // Enqueue the neighbor
                    queue.Enqueue((i,j));
                    // Update the distance
                    grid[i][j] = 1 + grid[r][c]; 
                }
            }
        }
    }

    // Leetcode 994 - Rotting Oranges
    // Approach : Multi-Source BFS
    // Time Complexity : O(m*n)
    // Space Complexity : O(m*n)
    // Type: Medium
    public class OrangesRottingLC994
    {
        public int OrangesRotting(int[][] grid) {
            // Create a queue for BFS
            Queue<(int r,int c)> queue = new();
            // Get the dimensions of the grid
            int n = grid.Length;
            int m = grid[0].Length;
            // Count of fresh oranges
            int count = 0;

            // Add all the rotten oranges to the queue and count the fresh oranges
            for(int i = 0; i < n;i++)
            {
                for(int j = 0; j < m;j++)
                {
                    if(grid[i][j] == 2)
                    {
                        queue.Enqueue((i,j));
                    }
                    else if(grid[i][j] == 1)
                    {
                        count++;
                    }
                }
            }
            // Time in minutes
            int minutes = 0;
            // Directions for moving in the grid
            int[][] directions = [[-1,0],[1,0],[0,1],[0,-1]];
            // Perform BFS
            while(queue.Count > 0)
            {
                // Get the size of the queue
                int size = queue.Count;
                // Process all the rotten oranges in the current level
                for(int q = 0; q < size; q++)
                {
                    // Dequeue the rotten orange
                    (int i, int j) = queue.Dequeue();
                    // Check the four neighbors
                    foreach(var direction in directions)
                    {
                        int ni = i + direction[0];
                        int nj = j + direction[1];

                        // Check if the neighbor is valid
                        // Check if the neighbor is valid
                        if(ni < 0 || ni >= n || nj < 0 || nj >= m || grid[ni][nj] != 1)
                        {
                            continue;
                        }
                        // If the neighbor is fresh, rot it
                        else
                        {
                            // Mark the neighbor as rotten
                            grid[ni][nj] = 2;
                            // Enqueue the neighbor
                            queue.Enqueue((ni,nj));
                            // Decrement the count of fresh oranges
                            count--;
                        }
                    }
                }
                // Increment the time if there are rotten oranges
                if(queue.Count > 0)
                    minutes++;
            }
            // Return the time if all oranges are rotten, otherwise return -1
            return count > 0 ? -1 : minutes;
        }
    }

    //  Leetcode 417 - Pacific Atlantic Water Flow
    // Approach : Multi-Source BFS
    // Time Complexity : O(m*n)
    // Space Complexity : O(m*n)
    // Type: Medium
    public class PacificAtlanticLC417
    {
        public List<IList<int>> PacificAtlantic(int[][] heights) {
            int n = heights.Length; // rows
            int m = heights[0].Length; // columns
            // visited arrays for both oceans
            bool[,] pac = new bool[n,m];
            bool[,] atl = new bool[n,m];
            // result list
            List<IList<int>> result = new();
            // directions for moving in the grid
            int[][] directions = [[-1,0],[1,0],[0,-1],[0,1]];
            // DFS function to find all the cells that can reach the ocean
            void DFS(int i, int j,bool[,] visited)
            {
                // Mark the current cell as visited
                visited[i,j] = true;
                // Check the four neighbors
                foreach(var direction in directions)
                {
                    // Get the new coordinates
                    int r = i + direction[0];
                    int c = j + direction[1];

                    // Omit if the new coordinates are invalid
                    if(r < 0 || r >= n || c < 0 || c >= m 
                        || visited[r,c] == true || heights[r][c] < heights[i][j])
                    {
                        continue;
                    }
                    // Recursively call DFS for the new coordinates
                    DFS(r,c,visited);
                }
                return;
            }

            for(int i = 0; i < n; i++)
            {
                // topmost border - pacific ocean
                DFS(i,0,pac);
                // rightmost border - atlantic ocean
                DFS(i,m-1,atl);
            }
            for(int j = 0; j < m; j++)
            {
                // leftmost border - pacific ocean
                DFS(0,j,pac);
                // bottom most border - atlantic ocean
                DFS(n-1,j,atl);
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m;j++)
                {
                    // If both visited arrays have true at the same cell, add it to the result
                    if(pac[i,j] == true && atl[i,j] == true)
                    {
                        result.Add([i,j]);
                    }
                }
            }
            // Return the result
            return result;
        }
    }
}

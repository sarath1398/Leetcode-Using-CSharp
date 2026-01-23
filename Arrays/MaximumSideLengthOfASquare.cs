namespace Arrays
{
    // Leetcode : 1292 - Maximum Side Length of a Square with Sum Less than or Equal to Threshold
    // Approach : Prefix Sum
    // Time Complexity : O(n*m*Min(m,n))
    // Space Complexity : O(n*m)
    // Type: Medium
    internal class MaximumSideLengthOfASquare
    {
        // TODO : Work on Binary search variants and Optimal Sliding Window technique for this problem

        public static int MaxSideLength(int[][] mat, int threshold)
        {
            int n = mat.Length; // row
            int m = mat[0].Length; // column

            int[,] prefixSum = new int[n, m];

            // Build prefix sum 2D array
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0 && j == 0)
                        prefixSum[i, j] = mat[i][j];
                    else
                    {
                        if (j == 0)
                        {
                            prefixSum[i, j] = prefixSum[i - 1, j] + mat[i][j];
                        }
                        else if (i == 0)
                        {
                            prefixSum[i, j] = prefixSum[i, j - 1] + mat[i][j];
                        }
                        else
                        {
                            int currentElement = mat[i][j];
                            int rowMax = prefixSum[i - 1, j];
                            int colMax = prefixSum[i, j - 1];
                            int doubleAdd = prefixSum[i - 1, j - 1];
                            prefixSum[i, j] = rowMax + colMax + currentElement - doubleAdd;
                        }
                    }
                }
            }

            int max = Math.Min(n, m); // Square will be always the lesser side of the m*n matrix

            // early return from max to min
            for (int len = max; len > 0; len--)
            {
                for (int i = len - 1; i < n; i++)
                {
                    for (int j = len - 1; j < m; j++)
                    {
                        int total = prefixSum[i, j]; // total area
                        if (i - len >= 0)
                            total -= prefixSum[i - len, j]; // subtract upper portion of ideal square
                        if (j - len >= 0)
                            total -= prefixSum[i, j - len]; // subtract left portion of ideal square
                        if (i - len >= 0 && j - len >= 0) 
                            total += prefixSum[i - len, j - len]; // add the overlap element
                        if (total <= threshold)
                            return len;
                    }
                }
            }

            return 0;
        }
    }
}

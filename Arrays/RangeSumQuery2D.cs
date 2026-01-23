namespace Arrays
{
    // Leetcode : 304 - Range Sum Query 2D - Immutable
    // Approach : 2D Prefix Sum
    // Time Complexity : O(1) per query
    // Space Complexity : O(n*m)
    // Type: Medium
    public class NumMatrix
    {

        private readonly int[,] prefixSumMatrix;
        public NumMatrix(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            prefixSumMatrix = new int[rows + 1, cols + 1];
            for (int i = 1; i < rows + 1; i++)
            {
                for (int j = 1; j < cols + 1; j++)
                {
                    int value = matrix[i - 1][j - 1];
                    // add total sum of row and column with current matrix value
                    prefixSumMatrix[i, j] = prefixSumMatrix[i - 1, j] + prefixSumMatrix[i, j - 1] + value;
                    // subtract top left value since it overlaps with row and col sum
                    prefixSumMatrix[i, j] -= prefixSumMatrix[i - 1, j - 1];
                }
            }
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            int totalSum = prefixSumMatrix[row2 + 1, col2 + 1];
            int colSum = prefixSumMatrix[row1, col2 + 1];
            int rowSum = prefixSumMatrix[row2 + 1, col1];
            int topLeft = prefixSumMatrix[row1, col1];
            return totalSum - colSum - rowSum + topLeft;
        }
    }

    /**
    * Your NumMatrix object will be instantiated and called as such:
    * NumMatrix obj = new NumMatrix(matrix);
    * int param_1 = obj.SumRegion(row1,col1,row2,col2);
    */
}

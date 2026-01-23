namespace Arrays
{
    // Leetcode : 1929 - Concatenation of Array
    // Approach : Simulation
    // Time Complexity : O(n)
    // Space Complexity : O(n)
    // Type: Easy
    public class ConcatenationOfArray
    {
        public static int[] GetConcatenation(int[] nums)
        {
            int n = nums.Length;
            int[] ans = new int[n * 2];
            for (int i = 0; i < n; i++)
            {
                ans[i] = nums[i];
                ans[n + i] = nums[i];
            }
            return ans;
        }
    }
}

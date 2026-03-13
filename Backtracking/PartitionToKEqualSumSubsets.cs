namespace Backtracking
{
    // Leetcode - 698
    // Approach : Backtracking
    // Time Complexity : O(k * 2^n)
    // Space Complexity : O(n)
    // Type: Medium
    public class PartitionToKEqualSumSubsets
    {
        public bool CanPartitionKSubsets(int[] nums, int k)
        {
            // Calculate sum of all elements
            int sum = nums.ToList().Sum();
            // If sum is not divisible by k, return false
            if (sum % k != 0)
                return false;
            // Target sum for each subset
            int target = sum / k;
            // Sort and reverse the array for optimization
            Array.Sort(nums);
            Array.Reverse(nums);
            // Visited array to keep track of visited elements
            bool[] visited = new bool[nums.Length];
            // DFS function to find the subsets
            bool dfs(int index, int k, int total)
            {
                // Base case: if k is 0, we have found all subsets
                if (k == 0)
                    return true;
                // If total equals target, we have found a subset
                if (total == target)
                {
                    // Reset total to 0 and decrement k
                    return dfs(0, k - 1, 0);
                }
                // Iterate through the array
                for (int i = index; i < nums.Length; i++)
                {
                    // If element is visited or total + element > target, continue
                    if (visited[i] == true || (total + nums[i] > target))
                    {
                        continue;
                    }
                    // Mark element as visited
                    visited[i] = true;
                    // Recurse for the next element
                    if (dfs(i + 1, k, total + nums[i]))
                        return true;
                    // Backtrack
                    visited[i] = false;
                    // Optimization: if total is 0, return false
                    if (total == 0) return false;
                }
                return false;
            }
            // Start DFS from index 0, k subsets, and total 0
            return dfs(0, k, 0);
        }
    }
}
